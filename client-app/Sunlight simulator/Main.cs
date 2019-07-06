using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Globalization;

namespace Simulatore_luce_solare
{
    public partial class Main : Form
    {
        public CDay Day { get; set; }
        private DataPoint curr;
        private double Timestep;
        public IModel Channel { get; set; }
        public IConnection Connection { get; set; }
        public IConnectionFactory Factory { get; set; }
        public bool Connected { get; set; }
        private int SimulationOn;
        public System.Threading.Timer TryConnection { get; set; }

        private DataPoint[] Powers;
        private int PowersIndex;

        private int mConstant;
        private int hConstant;
        private bool ConstantOn;
        private bool newAdvancedStarted;
        private int currMeasure;
        private bool[,] valueInserted;
        private Point[] PortraitPoints;
        private Size PortraitSize;
        private Point[] LandscapePoints;
        private Size LandscapeSize;
        private CChannel[] newChannels;
        private CChannel newChannel;
        private int[] currDotPos;
        private PictureBox currDot;
        private int dotInserted;
        private fWaiting f;
        private CChannel[] chanLandscape;
        private CChannel[] chanPortrait;
        private int numChan;
        private int[] chanLevelsConstant;
        private string Report;
        private DateTime SimulationStart;
        private DateTime SimulationEnd;

        private CStandard Standard;
        private bool newStandardStarted;
        private bool interrupted;
        private fIP formIP;
        private void Connetti(object Sender)
        {
            try
            {
                Factory = new ConnectionFactory { UserName = "default", Password = "default", HostName = formIP.IP };
                Connection = Factory.CreateConnection();
                Channel = Connection.CreateModel();

                this.Connected = true;
            }
            catch (Exception)
            {

            }

        }
        
        private void NoSimulationOn()
        {
            SimulationOn = -1;
            ConstantOn = false;
            cbAllow.Enabled = false;
            cbAllow.Checked = false;
            
            if (Connected)
            {
                btnLoadConstant.Enabled = true;
                pnlDuration.Enabled = true;
                pnlPower.Enabled = true;
                if(rbStandard2.Checked)
                    pnlNewStandard.Enabled = true;
                else
                {
                    pnlNewAdvanced.Enabled = true;
                    pnlDisplay.Enabled = true;
                }
                pnlMode2.Enabled = true;
                pnlMode1.Enabled = true;
            }
            btnResetSimulation.Enabled = false;
            btnResetConstant.Enabled = false;
            if (Day != null)
            {
                if (Connected)
                {
                    btnLoadSimulation.Enabled = true;
                }

                dtpEnd.Enabled = true;
                dtpStart.Enabled = true;
                cbTime.Enabled = true;
                if (cbTime.Checked)
                {
                    nudHours.Enabled = true;
                    nudMinutes.Enabled = true;
                }
            }



            if (chart.Series.Count == 3)
                chart.Series.RemoveAt(2);
            if (chart.Series.Count >= 2)
                chart.Series[1].Enabled = true;
            timerSimulation.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Connected)
            {
                Channel.QueueDeclare("PCtoPI", false, false, false, null);
                Channel.ExchangeDeclare("PCtoPI", ExchangeType.Direct, false, false, null);
                Channel.QueueBind("PCtoPI", "PCtoPI", "", null);
                Channel.QueueDeclare("PItoPC", false, false, false, null);
                Channel.ExchangeDeclare("PItoPC", ExchangeType.Direct, false, false, null);
                Channel.QueueBind("PItoPC", "PItoPC", "", null);
                Channel.QueuePurge("PItoPC");
                var consumer = new EventingBasicConsumer(Channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var props = ea.BasicProperties;

                    string message = Encoding.UTF8.GetString(body);
                    int Object = (int)props.Headers["object"];
                    switch (Object)
                    {
                        case 0:
                            if (message[0] == 's' && message[1] != 't')
                            {
                                if (f != null)
                                {
                                    this.BeginInvoke((MethodInvoker)delegate ()
                                    {
                                        f.Close();
                                        this.Enabled = true;
                                    });
                                }
                                if (newAdvancedStarted)
                                {

                                }
                                else if (newStandardStarted)
                                {
                                    
                                }
                                else if (ConstantOn)
                                {
                                    Report = message.Substring(1);
                                    string[] p = Report.Split(';');
                                    chanLevelsConstant = new int[6];
                                    for(int i=0; i<6; i++)
                                    {
                                        chanLevelsConstant[i] = Int32.Parse(p[i]);
                                        (this.Controls.Find("ucSliderConstant" + (i + 1), true)[0] as ucSlider).Value = chanLevelsConstant[i];
                                    }
                                    SimulationOn = 1;
                                    this.BeginInvoke((MethodInvoker)delegate ()
                                    {
                                        cbAllow.Enabled = true;
                                        timerSimulation.Enabled = true;

                                    });                                }
                                else
                                {
                                    Report = message.Substring(1);
                                    StartSimulation();
                                }
                            }
                            else if (message == "r")
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    if (f != null)
                                    {
                                        f.Close();
                                        this.Enabled = true;
                                        f.Dispose();
                                        f = null;
                                    }
                                    if (newAdvancedStarted)
                                    {
                                        ResetNewAdvancedPanel();
                                    }
                                    else if (newStandardStarted)
                                    {
                                        ResetNewStandardPanel();
                                    }
                                    else
                                    {
                                        SimulationEnd = DateTime.Now;
                                        if (interrupted || ConstantOn)
                                        {
                                            MessageBox.Show("Simulation interrupted!", "", MessageBoxButtons.OK);
                                        }
                                        else
                                        {
                                            if (MessageBox.Show("Simulation completed! Would you like to read the Report file?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                            {
                                                StreamWriter reportFile = File.CreateText("report.txt");
                                                reportFile.WriteLine("Simulation started on " + SimulationStart.ToString("f", new CultureInfo("en-US")));
                                                reportFile.WriteLine("Simulation ended on " + SimulationEnd.ToString("f", new CultureInfo("en-US")));
                                                reportFile.WriteLine();
                                                reportFile.WriteLine("This report contains the powers minute per minute and their relative channel levels." + Environment.NewLine + "Pre-heating and cooling powers are omitted.");
                                                reportFile.WriteLine();
                                                reportFile.WriteLine();
                                                
                                                string[] s = Report.Split('/');
                                                string[] levels = s[0].Split(';');
                                                int levelsIndex = 0;
                                                string[] powers = s[1].Split(';');
                                                for (int i = 0; i < powers.GetLength(0)-1; i++)
                                                {
                                                    reportFile.WriteLine("Minute n." + (i + 1) + ":");
                                                    reportFile.WriteLine(" Power = " + powers[i] + "W/m2");
                                                    for(int j=0; j<6; j++)
                                                    {
                                                        reportFile.Write(" Ch. " + (j + 1) + ": " + levels[levelsIndex] + "/255");
                                                        if (j != 5)
                                                            reportFile.Write(",");

                                                        levelsIndex++;
                                                    }
                                                    reportFile.WriteLine();
                                                    reportFile.WriteLine();
                                                }
                                                reportFile.WriteLine();
                                                reportFile.WriteLine("End of simulation.");
                                                reportFile.Close();
                                                System.Diagnostics.Process.Start("report.txt");

                                            }
                                        }
                                        
                                        for (int i = 0; i < 6; i++)
                                        {
                                            (this.Controls.Find("ucSliderConstant" + (i + 1), true)[0] as ucSlider).Value = 0;
                                        }
                                        NoSimulationOn();
                                    }

                                });
                                
                            }
                            else if(message == "h")
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    this.Enabled = false;
                                    if (newAdvancedStarted)
                                    {
                                        f = new fWaiting("Pre-heating of the spotlights in progress", "Cancel calibration");
                                        f.ShowDialog();
                                        if(f.DialogResult == DialogResult.Abort)
                                        {
                                            Send("PCtoPI", 1, "r");
                                        }
                                    }
                                    else if (newStandardStarted)
                                    {
                                        f = new fWaiting("Pre-heating of the spotlights in progress", "Cancel calibration");
                                        f.ShowDialog();
                                        if (f.DialogResult == DialogResult.Abort)
                                        {
                                            Send("PCtoPI", 1, "r");
                                        }
                                    }
                                    else
                                    {
                                        SimulationStart = DateTime.Now;
                                        f = new fWaiting("Pre-heating of the spotlights in progress", "Cancel simulation");
                                        f.ShowDialog();
                                        if(f.DialogResult == DialogResult.Abort)
                                        {
                                            Send("PCtoPI", 1, "r");
                                        }
                                        else
                                        {
                                            lblChart.Visible = true;
                                            timerHeating.Enabled = true;
                                            nDots = 0;
                                            btnResetSimulation.Enabled = true;
                                            pnlDisplay.Enabled = false;
                                            pnlNewAdvanced.Enabled = false;
                                            pnlNewStandard.Enabled = false;
                                            pnlMode1.Enabled = false;
                                            pnlMode2.Enabled = false;
                                            pnlPower.Enabled = false;
                                            btnLoadConstant.Enabled = false;
                                            pnlDuration.Enabled = false;
                                            btnLoadSimulation.Enabled = false;
                                            btnLoadConstant.Enabled = false;
                                            btnResetConstant.Enabled = true;
                                            dtpEnd.Enabled = false;
                                            dtpStart.Enabled = false;
                                            nudHours.Enabled = false;
                                            nudMinutes.Enabled = false;
                                            cbTime.Enabled = false;
                                            if (!ConstantOn)
                                                chart.Series[1].Enabled = false;
                                        }
                                    }
                                });
                            }
                            else if(message == "c")
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    f = new fWaiting("Cooling of the spotlights in progress", "");
                                    f.Show();
                                    this.Enabled = false;
                                    if (newAdvancedStarted)
                                    {
                                        
                                    }
                                    else if (newStandardStarted)
                                    {

                                    }
                                    else
                                    {
                                        lblChart.Visible = true;
                                        timerHeating.Enabled = true;
                                        nDots = 0;
                                    }
                                });
                            }
                            else if(message == "l")
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    rbLandscape.Checked = true;
                                    rbPortrait.Checked = false;
                                });
                            }
                            else if(message == "p"){
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    rbLandscape.Checked = false;
                                    rbPortrait.Checked = true;
                                });
                            }
                            else if(message == "st")
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    rbStandard2.Checked = true;
                                    rbAdvanced2.Checked = false;
                                    rbStandard1.Checked = true;
                                    rbAdvanced1.Checked = false;
                                    pnlNewStandard.Enabled = true;
                                    pnlNewAdvanced.Enabled = false;
                                    pnlDisplay.Enabled = true;
                                });
                            }
                            else if(message == "ad")
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    rbStandard2.Checked = false;
                                    rbAdvanced2.Checked = true;
                                    rbStandard1.Checked = false;
                                    rbAdvanced1.Checked = true;
                                    pnlNewStandard.Enabled = false;
                                    pnlNewAdvanced.Enabled = true;
                                    pnlDisplay.Enabled = true;
                                });
                            }
                            break;
                        case 1:
                            this.BeginInvoke((MethodInvoker)delegate ()
                            {
                                pbConnection1.Image = Simulatore_luce_solare.Properties.Resources.Green;
                                pbConnection2.Image = Simulatore_luce_solare.Properties.Resources.Green;
                                pbConnection3.Image = Simulatore_luce_solare.Properties.Resources.Green;
                                pbConnection4.Image = Simulatore_luce_solare.Properties.Resources.Green;

                                lblConnected1.Text = "Connected";
                                lblConnected1.ForeColor = Color.FromArgb(51, 153, 51);
                                lblConnected2.Text = "Connected";
                                lblConnected2.ForeColor = Color.FromArgb(51, 153, 51);
                                lblConnected3.Text = "Connected";
                                lblConnected3.ForeColor = Color.FromArgb(51, 153, 51);
                                lblConnected4.Text = "Connected";
                                lblConnected4.ForeColor = Color.FromArgb(51, 153, 51);
                  
                                if (f != null)
                                {
                                    this.BeginInvoke((MethodInvoker)delegate ()
                                    {
                                        f.Close();
                                        this.Enabled = true;
                                        f.Dispose();
                                        f = null;
                                    });
                                }
                                if (message == "yes")
                                {
                                    btnResetSimulation.Enabled = true;
                                    btnLoadSimulation.Enabled = false;
                                    btnLoadConstant.Enabled = false;
                                    btnResetConstant.Enabled = true;
                                    pnlDisplay.Enabled = false;
                                    pnlNewAdvanced.Enabled = false;
                                    pnlNewStandard.Enabled = false;
                                    pnlMode1.Enabled = false;
                                    pnlMode2.Enabled = false;
                                    SimulationOn = 1;
                                }

                                else if(message == "no")
                                {
                                    if (Day != null)
                                        btnLoadSimulation.Enabled = true;
                                    btnLoadConstant.Enabled = true;
                                    NoSimulationOn();
                                }
                            });
                            break;
                        case 2:
                            this.BeginInvoke((MethodInvoker)delegate ()
                            {
                                string[] powers = message.Split(';');
                                int powersIndex = 0;
                                cbChannels.Items.Clear();
                                chanLandscape = new CChannel[numChan];
                                chanPortrait = new CChannel[numChan];
                                for (int c=0; c< numChan; c++)
                                {
                                    int[,] Powers = new int[2, 3];
                                    for(int i=0; i<2; i++)
                                    {
                                        for(int j=0; j<3; j++)
                                        {
                                            Powers[i,j] = Int32.Parse(powers[powersIndex]);
                                            powersIndex++;
                                        }
                                    }
                                    int[] Channels = new int[(6 / numChan)];
                                    for(int i=0; i< 6/numChan; i++)
                                    {
                                        Channels[i] = c * 6 / numChan + i;
                                    }
                                   
                                    chanLandscape[c] = new CChannel(Powers, Channels);
                                    if (rbLandscape.Checked)
                                        cbChannels.Items.Add(chanLandscape[c]);
                                }
                                for (int c = 0; c < numChan; c++)
                                {
                                    int[,] Powers = new int[2, 3];
                                    for (int i = 0; i < 2; i++)
                                    {
                                        for (int j = 0; j < 3; j++)
                                        {
                                            Powers[i, j] = Int32.Parse(powers[powersIndex]);
                                            powersIndex++;
                                        }
                                    }
                                    int[] Channels = new int[(6 / numChan)];
                                    for (int i = 0; i < 6 / numChan; i++)
                                    {
                                        Channels[i] = c * 6 / numChan + i;
                                    }
                                    chanPortrait[c] = new CChannel(Powers, Channels);
                                    if (rbPortrait.Checked)
                                        cbChannels.Items.Add(chanPortrait[c]);
                                }
                            });
                            break;
                        case 3:
                            if(message == "e")
                            {
                                MessageBox.Show("Error on the Raspberry PI!" + Environment.NewLine + "Restarting the program...");
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    Connected = false;
                                    pbConnection1.Image = Simulatore_luce_solare.Properties.Resources.Red;
                                    pbConnection2.Image = Simulatore_luce_solare.Properties.Resources.Red;
                                    pbConnection3.Image = Simulatore_luce_solare.Properties.Resources.Red;
                                    pbConnection4.Image = Simulatore_luce_solare.Properties.Resources.Red;
                                   
                                    lblConnected1.Text = "Not connected";
                                    lblConnected1.ForeColor = Color.Red;
                                    lblConnected2.Text = "Not connected";
                                    lblConnected2.ForeColor = Color.Red;
                                    lblConnected3.Text = "Not connected";
                                    lblConnected3.ForeColor = Color.Red;
                                    lblConnected4.Text = "Not connected";
                                    lblConnected4.ForeColor = Color.Red;
                                  
                                    pnlDisplay.Enabled = false;
                                    pnlNewAdvanced.Enabled = false;
                                    pnlNewStandard.Enabled = false;
                                    NoSimulationOn();
                                    for (int i = 0; i < 6; i++)
                                    {
                                        (this.Controls.Find("ucSliderConstant" + (i + 1), true)[0] as ucSlider).Value = 0;
                                    }
                                    btnLoadSimulation.Enabled = false;
                                    btnResetSimulation.Enabled = false;
                                    btnLoadConstant.Enabled = false;
                                    btnResetConstant.Enabled = false;
                                });
                            }
                            break;
                        case 4:
                            {
                                string[] powers = message.Split(';');
                                int[] Powers = new int[numChan];
                                for(int i=0; i<6; i++){
                                    Powers[i] = Int32.Parse(powers[i]);
                                    (this.Controls.Find("ucSlider" + (i + 1), true)[0] as ucSlider).Value = Powers[i];
                                }
                                Standard = new CStandard(600, Powers);
                                break;
                            }
                    }
                };
                Channel.BasicConsume("PItoPC", true, consumer);
                Send("PCtoPI", 1, "s");
                TryConnection.Dispose();
                timerConnection.Enabled = false;
            }
        }

        
        public Main()
        {
            InitializeComponent();
            mConstant = 0;
            hConstant = 1;
            interrupted = false;
            PortraitPoints = new Point[7];
            PortraitPoints[0] = new Point(142, 88);
            PortraitPoints[1] = new Point(142, 149);
            PortraitPoints[2] = new Point(142, 212); 
            PortraitPoints[3] = new Point(207, 88);
            PortraitPoints[4] = new Point(207, 149);
            PortraitPoints[5] = new Point(207, 212);
            PortraitPoints[6] = new Point(25, 0);
            PortraitSize = new Size(314, 361);

            LandscapePoints = new Point[7];
            LandscapePoints[0] = new Point(104, 123);
            LandscapePoints[1] = new Point(176, 123);
            LandscapePoints[2] = new Point(250, 123);
            LandscapePoints[3] = new Point(104, 183);
            LandscapePoints[4] = new Point(176, 183);
            LandscapePoints[5] = new Point(250, 183);
            LandscapePoints[6] = new Point(11, -46);
            LandscapeSize = new Size(347, 387);

            formIP = new fIP();
            numChan = 6;
            rbLandscape.Checked = true;
            SimulationOn = 0;
            newAdvancedStarted = false;
            newStandardStarted = false;
            pnlDisplay.Enabled = false;
            pnlNewAdvanced.Enabled = false;
            pnlNewStandard.Enabled = false;
            cbChannels.Text = "--Select a channel--";
            pnlMode2.Enabled = false;
            pnlMode1.Enabled = false;
            Day = null;
            Connected = false;
            TryConnection = new System.Threading.Timer(new System.Threading.TimerCallback(Connetti), null, 0, 1000);
         }

        Point? prevPosition = new Point?(new Point(0, 0));
        DataPoint prevPoint = null;
        ToolTip ttChart = new ToolTip();
        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;

            if (Math.Abs(prevPosition.Value.X - pos.X) > 5 || Math.Abs(prevPosition.Value.Y - pos.Y) > 5)
            {
                ttChart.RemoveAll();
            }
            if(curr == null)
            {
                if (chart.Series.Count > 0)
                    for (int i = 0; i < chart.Series[0].Points.Count-1; i++)
                    {
                        double x = chart.ChartAreas[0].AxisX.ValueToPixelPosition(chart.Series[0].Points[i].XValue);
                        bool Left;
                        bool Right;
                        if (i == 0)
                            Left = true;
                        else
                            Left = pos.X > (x + chart.ChartAreas[0].AxisX.ValueToPixelPosition(chart.Series[0].Points[i - 1].XValue)) / 2;
                        if (i == chart.Series[0].Points.Count-1)
                            Right = true;
                        else
                            Right = pos.X < (x + chart.ChartAreas[0].AxisX.ValueToPixelPosition(chart.Series[0].Points[i + 1].XValue)) / 2;
                        if (Left && Right)
                        {

                            chart.Series[0].Points[i].MarkerStyle = MarkerStyle.Circle;
                            chart.Series[0].Points[i].MarkerSize = 10;
                            if (prevPoint != chart.Series[0].Points[i] || Math.Abs(prevPosition.Value.X - pos.X) > 5 || Math.Abs(prevPosition.Value.Y - pos.Y) > 5)
                            {
                                double hours = Math.Floor(chart.Series[0].Points[i].XValue);
                                double minutes = Math.Round((chart.Series[0].Points[i].XValue - hours) * 60);
                                string hoursString;
                                if (hours < 10)
                                    hoursString = "0" + hours;
                                else
                                    hoursString = "" + hours;
                                string minutesString;
                                if (minutes < 10)
                                    minutesString = "0" + minutes;
                                else
                                    minutesString = "" + minutes;
                                ttChart.Show("Ore = " + hoursString + ":" + minutesString + Environment.NewLine + "Potenza = " + chart.Series[0].Points[i].YValues[0] + "W/m2", this.chart,
                                               pos.X + 15, pos.Y + 15);
                            }

                            prevPoint = chart.Series[0].Points[i];
                        }
                        else
                            chart.Series[0].Points[i].MarkerStyle = MarkerStyle.None;
                    }
            }
            else
            {
                double XValue;
                if (e.Location.X > chart.ChartAreas[0].AxisX.ValueToPixelPosition(24))
                    XValue = 23.99;
                else if (e.Location.X < chart.ChartAreas[0].AxisX.ValueToPixelPosition(0))
                    XValue = 0;
                else
                    XValue = chart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
                if(curr == chart.Series[1].Points[0])
                {
                    if (XValue > chart.Series[1].Points[1].XValue - 1)
                        curr.XValue = chart.Series[1].Points[1].XValue - 1;
                    else
                        curr.XValue = XValue;
                    int min = (int)((curr.XValue - ((double)((int)curr.XValue))) * 60.0);
                    dtpStart.Value = new DateTime(2000, 1, 1, (int)curr.XValue, min, 00);
                    chart.Annotations[0].X = curr.XValue;
                }
                else
                {
                    if (XValue < chart.Series[1].Points[0].XValue + 1)
                        curr.XValue = chart.Series[1].Points[0].XValue + 1;
                    else
                        curr.XValue = XValue;
                    int min = (int)((curr.XValue - ((double)((int)curr.XValue))) * 60.0);
                    dtpEnd.Value = new DateTime(2000, 1, 1, (int)curr.XValue, min, 00);
                    chart.Annotations[1].X = curr.XValue;
                }
                if (!cbTime.Checked)
                {
                    TimeSpan delta = dtpEnd.Value - dtpStart.Value;
                    nudHours.Value = delta.Hours;
                    nudMinutes.Value = delta.Minutes;
                }
            }
            
            prevPosition = pos;
            
          

        }

        private void chart_MouseLeave(object sender, EventArgs e)
        {
            if (curr != null)
                curr = null;
            if (chart.Series.Count > 0)
                for (int i = 0; i < chart.Series[0].Points.Count; i++)
                {
                        chart.Series[0].Points[i].MarkerStyle = MarkerStyle.None;
                }
            ttChart.RemoveAll();
        }

        private void chart_MouseDown(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            var results = chart.HitTest(pos.X, pos.Y, false,
                                    ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {

                    if (result.Series == chart.Series[1])
                    {
                        curr = result.Object as DataPoint;
                        if (chart.Series.Count > 0)
                            for (int i = 0; i < chart.Series[0].Points.Count; i++)
                            {
                                chart.Series[0].Points[i].MarkerStyle = MarkerStyle.None;
                            }
                        ttChart.RemoveAll();
                    }
                }
            }

        }

        private void chart_MouseUp(object sender, MouseEventArgs e)
        {
            
            curr = null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dtpStart.Value = new DateTime(2000, 1, 1, 0, 0, 00);
            dtpEnd.Value = new DateTime(2000, 1, 1, 23, 59, 00);
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            nudHours.Value = 24;
            btnLoadSimulation.Enabled = false;
            btnResetSimulation.Enabled = false;
            cbTime.Enabled = false;
        }

        
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if(Day != null)
            {
                chart.Series[1].Points[0].XValue = dtpStart.Value.Hour + (double)dtpStart.Value.Minute / 60.0;
                if (chart.Series[1].Points[0].XValue > chart.Series[1].Points[1].XValue - 1)
                {
                    chart.Series[1].Points[0].XValue = chart.Series[1].Points[1].XValue - 1;
                    int min = (int)((chart.Series[1].Points[0].XValue - ((double)((int)chart.Series[1].Points[0].XValue))) * 60.0);
                    dtpStart.Value = new DateTime(2000, 1, 1, (int)chart.Series[1].Points[0].XValue, min, 00);
                }
                chart.Annotations[0].X = chart.Series[1].Points[0].XValue;
            }
            if (!cbTime.Checked)
            {
                TimeSpan delta = dtpEnd.Value - dtpStart.Value;
                nudHours.Value = delta.Hours;
                nudMinutes.Value = delta.Minutes;
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if(Day != null)
            {
                chart.Series[1].Points[1].XValue = dtpEnd.Value.Hour + (double)dtpEnd.Value.Minute / 60.0;
                if (chart.Series[1].Points[1].XValue < chart.Series[1].Points[0].XValue + 1)
                {
                    chart.Series[1].Points[1].XValue = chart.Series[1].Points[0].XValue + 1;
                    int min = (int)((chart.Series[1].Points[1].XValue - ((double)((int)chart.Series[1].Points[1].XValue))) * 60.0);
                    dtpEnd.Value = new DateTime(2000, 1, 1, (int)chart.Series[1].Points[1].XValue, min, 00);
                }
                    
                chart.Annotations[1].X = chart.Series[1].Points[1].XValue;
            }
            if (!cbTime.Checked)
            {
                TimeSpan delta = dtpEnd.Value - dtpStart.Value;
                nudHours.Value = delta.Hours;
                nudMinutes.Value = delta.Minutes;
            }
            
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to start the simulation with the current calibration?" + Environment.NewLine + Environment.NewLine + 
                "NOTE: Every new setup requires a new calibration.", "START SIMULATION", MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
                return;
            string powers = "";
            interrupted = false;
            if (sender == Controls.Find("btnLoadSimulation", true)[0])
            {
                TimeSpan t = dtpEnd.Value - dtpStart.Value;
                int nPowers = (int)nudHours.Value * 60 + (int)nudMinutes.Value;
                Powers = new DataPoint[nPowers];
                Timestep = t.TotalMinutes * 60000.0 / (double)nPowers;
                CLine currLine = new CLine(chart.Series[0].Points[0], chart.Series[0].Points[1]);
                int currPointIndex = 0;


                DateTime dtIterator = new DateTime(2000, 1, 1, dtpStart.Value.Hour, dtpStart.Value.Minute, 0);
                for (int i = 0; i < nPowers; i++)
                {
                    double currT = (double)dtIterator.Hour + ((double)dtIterator.Minute / 60.0);
                    if (currT > currLine.End.XValue)
                    {
                        for (; currPointIndex < chart.Series[0].Points.Count; currPointIndex++)
                        {
                            if (chart.Series[0].Points[currPointIndex].XValue > currT)
                            {
                                currPointIndex--;
                                break;
                            }
                        }
                        currLine = new CLine(chart.Series[0].Points[currPointIndex], chart.Series[0].Points[currPointIndex + 1]);
                    }
                    Powers[i] = new DataPoint();
                    Powers[i].XValue = currT;
                    Powers[i].YValues[0] = (int)(currLine.Slope * currT + currLine.Intercept);
                    powers += Powers[i].YValues[0] + ";";
                    dtIterator = dtIterator.AddMilliseconds(Timestep);
                }
            }
            else
            {
                ConstantOn = true;
                int nPowers = (int)nudHoursConstant.Value * 60 + (int)nudMinutesConstant.Value;
                int power = (int)nudPowerConstant.Value;
                for (int i = 0; i < nPowers; i++)
                    powers += power + ";";
            }
            Send("PCtoPI", 0, powers);
        }

        private void Send(string Exchange, int Object, string Message)
        {
            var props = Channel.CreateBasicProperties();
            props.Headers = new Dictionary<string, object>();
            props.Headers.Add("Object", Object);
            byte[] body = Encoding.UTF8.GetBytes(Message);
            try
            {
                Channel.BasicPublish(Exchange, "", props, body);
            }

            catch (Exception)
            {
                MessageBox.Show("Communication attempt with the Raspberry PI failed!", "ERROR",MessageBoxButtons.OK);
                lblConnected1.ForeColor = Color.Red;
                lblConnected1.Text = "Not connected";
                lblConnected2.ForeColor = Color.Red;
                lblConnected2.Text = "Not connected";
                lblConnected2.ForeColor = Color.Red;
                lblConnected2.Text = "Not connected";
                lblConnected3.Text = "Not connected";
                lblConnected3.ForeColor = Color.Red;
                lblConnected4.ForeColor = Color.Red;
                lblConnected4.Text = "Not connected";

                Connected = false;
                pbConnection1.Image = Simulatore_luce_solare.Properties.Resources.Red;
                pbConnection2.Image = Simulatore_luce_solare.Properties.Resources.Red;
                pbConnection3.Image = Simulatore_luce_solare.Properties.Resources.Red;
                pbConnection4.Image = Simulatore_luce_solare.Properties.Resources.Red;

                timerConnection.Enabled = true;
                TryConnection = new System.Threading.Timer(new System.Threading.TimerCallback(Connetti), null, 0, 1000);
                btnLoadSimulation.Enabled = false;
                btnResetSimulation.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to stop the simulation in progress?", "STOP SIMULATION", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                interrupted = true;
                Send("PCtoPI", 1, "r");
                SimulationOn = 0;
                btnResetSimulation.Enabled = false;
            }
        }

        private void StartSimulation()
        {
            SimulationOn = 1;
            
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "SimulationPointer",
                Color = System.Drawing.Color.White,
                BorderColor = System.Drawing.Color.DarkRed,
                BorderWidth = 3,
                IsVisibleInLegend = false,
                IsXValueIndexed = false,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            };
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                timerSimulation.Enabled = true;
                chart.Series.Add(series);
                chart.Series[2].Points.Add(Powers[0]);
                chart.Series[2].MarkerStyle = MarkerStyle.Circle;
                chart.Series[2].MarkerSize = 10;
            });

            PowersIndex = 0;
        }
        private void timerSimulation_Tick(object sender, EventArgs e)
        {
            if (ConstantOn)
            {
                mConstant -= 1;
                if(mConstant == -1)
                {
                    mConstant = 59;
                    hConstant -= 1;
                    if(hConstant == -1)
                    {
                        timerSimulation.Enabled = false;
                        return;
                    }
                }
                string mString = mConstant + "";
                if (mConstant < 10)
                    mString = "0" + mString;
                lblTime.Text = hConstant + ":" + mString;
            }
            else
            {
                PowersIndex++;
                if (PowersIndex >= Powers.GetLength(0))
                {
                    timerSimulation.Enabled = false;
                    chart.Series.RemoveAt(2);
                    return;
                }
                chart.Series[2].Points[0] = Powers[PowersIndex];
            }
           
        }

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTime.Checked)
            {
                lblHour.Enabled = true;
                lblMinute.Enabled = true;
                nudHours.Enabled = true;
                nudMinutes.Enabled = true;
            }
            else
            {
                lblHour.Enabled = false;
                lblMinute.Enabled = false;
                nudHours.Enabled = false;
                nudMinutes.Enabled = false;
               
                TimeSpan delta = dtpEnd.Value - dtpStart.Value;
                nudHours.Value = delta.Hours;
                nudMinutes.Value = delta.Minutes;

            }
        }

        


        private void btnSaveNewAdvanced_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Overwrite the old calibration with the newly created one?", "", MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Cancel)
                return;
            if (d == DialogResult.Yes)
            {
                cbChannels.Items.Clear();
                string message = "";
                if (rbLandscape.Checked)
                {
                    chanLandscape = newChannels;
                }
                else
                {
                    chanPortrait = newChannels;
                }
                foreach(CChannel c in newChannels)
                {
                    cbChannels.Items.Add(c);
                }
                foreach (CChannel c in chanLandscape)
                {
                    for (int i = 0; i < c.Powers.GetLength(0); i++)
                    {
                        for (int j = 0; j < c.Powers.GetLength(1); j++)
                        {
                            message += c.Powers[i, j] + ";";
                        }
                    }
                }
                foreach (CChannel c in chanPortrait)
                {
                    for (int i = 0; i < c.Powers.GetLength(0); i++)
                    {
                        for (int j = 0; j < c.Powers.GetLength(1); j++)
                        {
                            message += c.Powers[i, j] + ";";
                        }
                    }
                }
                Send("PCtoPI", 2, message);
            }
            Send("PCtoPI", 1, "r");
        }

        private void btnNextAdvanced_Click(object sender, EventArgs e)
        {
            newChannels[currMeasure] = newChannel;
            dotInserted = 0;
            currMeasure++;
            if (currDot != null)
            {
                pbDot_MouseClick(pbDot1, e as MouseEventArgs);
            }
            if (dotInserted < 9)
            btnNextAdvanced.Enabled = false;

            if (currMeasure == numChan)
            {
                btnNextAdvanced.Enabled = false;
                pbNewAdvanced.Value += 60 / numChan;
                lblCurrChannel.Text = "";
                btnSaveNewAdvanced.Enabled = true;
                for (int i = 1; i < 7; i++)
                {
                    (Controls.Find("pbDot" + i, true)[0] as PictureBox).Enabled = false;
                    (Controls.Find("pbDot" + i, true)[0] as PictureBox).Image = Simulatore_luce_solare.Properties.Resources.dot1;

                }
                pbDisplay.Enabled = false;
                nudPower.Visible = false;
                btnConfirmDot.Visible = false;
                lblAdvanced.Text = "Regulation is concluded, select 'Done'" + Environment.NewLine + "to save or discard the new calibration";
            }
            else
            {
                lblCurrChannel.Text = "Measure n." + (currMeasure + 1);
                for (int i = 0; i < 6; i++)
                {
                    var dot = Controls.Find("pbDot" + (i + 1), true)[0] as PictureBox;
                    if (valueInserted[currMeasure, i])
                    {
                        dot.Image = Simulatore_luce_solare.Properties.Resources.Green;
                        dotInserted++;
                    }
                    else
                        dot.Image = Simulatore_luce_solare.Properties.Resources.dot1;

                }
                if (dotInserted == 6)
                    btnNextAdvanced.Enabled = true;
                int[] Channels = new int[(6 / numChan)];
                for (int i = 0; i < 6 / numChan; i++)
                {
                    Channels[i] = currMeasure * 6 / numChan + i;
                }
                Send("PCtoPI", 3, "" + currMeasure);
                if (newChannels[currMeasure] == null)
                    newChannel = new CChannel(Channels);
                else
                    newChannel = newChannels[currMeasure];
                pbNewAdvanced.Value +=  60 / numChan;
            }
            btnPreviousAdvanced.Enabled = true;
        }

        private void btnPreviousAdvanced_Click(object sender, EventArgs e)
        {
            currMeasure--;
            lblCurrChannel.Text = "Misura " + (currMeasure + 1);
            newChannel = newChannels[currMeasure];
            Send("PCtoPI", 3, "" + currMeasure);
            dotInserted = 0;

            if (currMeasure == numChan-1)
            {
                lblAdvanced.Text = "Select the dots on the display and" + Environment.NewLine + "insert the measured power...";
                for (int i = 1; i < 7; i++)
                {
                    (Controls.Find("pbDot" + i, true)[0] as PictureBox).Enabled = true;
                }
                pbDisplay.Enabled = true;
                nudPower.Visible = true;
                btnConfirmDot.Visible = true;
            }
            for (int i = 0; i < 6; i++)
            {
                var dot = Controls.Find("pbDot" + (i + 1), true)[0] as PictureBox;
                if (valueInserted[currMeasure, i])
                {
                    dot.Image = Simulatore_luce_solare.Properties.Resources.Green;
                    dotInserted++;
                }
                else
                    dot.Image = Simulatore_luce_solare.Properties.Resources.dot1;
              
            }
            if (dotInserted < 6)
                btnNextAdvanced.Enabled = false;
            if(currDot != null)
            {
                pbDot_MouseClick(pbDot1, e as MouseEventArgs);

            }
            if (currMeasure == 0)
            {
                btnPreviousAdvanced.Enabled = false;
            }
            pbNewAdvanced.Value -= 60 / numChan;
            btnNextAdvanced.Enabled = true;
        }

        private void btnCancelNewAdvanced_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to discard the new calibration?", "CANCEL", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Send("PCtoPI", 1, "r");
        }

        private void ResetNewAdvancedPanel()
        {
            newAdvancedStarted = false;
            btnCancelNewAdvanced.Enabled = false;
            btnNextAdvanced.Enabled = false;
            btnPreviousAdvanced.Enabled = false;
            lblAdvanced.Text = "Select 'New calibration' to start a" + Environment.NewLine + "new regulation of the channels";
            btnNewAdvanced.Enabled = true;
            pnlDisplay.Enabled = true;
            pbNewAdvanced.Value = 0;
            pbNewAdvanced.Enabled = false;
            btnSaveNewAdvanced.Enabled = false;
            cbChannels.Visible = true;
            currMeasure = 0;
            cbChannels.Visible = true;
            lblCurrChannel.Text = "";
            if(currDot != null)
            {
                currDot.Location = new Point(currDot.Location.X + 3, currDot.Location.Y + 3);
                currDot.Size = new Size(13, 13);
            }
            

            for (int i = 1; i < 7; i++)
            {
                var pbDot = (Controls.Find("pbDot" + i, true)[0] as PictureBox);
                pbDot.Enabled = false;
                pbDot.Image = Simulatore_luce_solare.Properties.Resources.dot1;
                pbDot.Cursor = System.Windows.Forms.Cursors.Default;
            }
            pbDisplay.Enabled = false;
            nudPower.Visible = false;
            btnConfirmDot.Visible = false;
            ((Control)tabPageConstant).Enabled = true;
            ((Control)tabPageStandard).Enabled = true;
        }

       

        private void btnNewAdvanced_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Start a new calibration of the channels?", "NEW CALIBRATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                valueInserted = new bool[numChan, 6];
                for (int i = 0; i < numChan; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        valueInserted[i, j] = false;
                    }
                }
                cbChannels.Visible = false;
                btnConfirmDot.Visible = true;
                nudPower.Visible = true;
                newAdvancedStarted = true;
                lblCurrChannel.Enabled = true;
                lblCurrChannel.Text = "Measure n.1";
                lblAdvanced.Text = "Select the dots on the display and" + Environment.NewLine + "insert the measured power...";
                btnCancelNewAdvanced.Enabled = true;
                btnNewAdvanced.Enabled = false;
                pnlDisplay.Enabled = false;
                pnlNewStandard.Enabled = false;
                btnNextAdvanced.Enabled = false;
                currMeasure = 0;
                newChannels = new CChannel[numChan];
                cbChannels.SelectedItem = null;
                for (int i = 1; i < 7; i++)
                {
                    (Controls.Find("pbDot" + i, true)[0] as PictureBox).Enabled = true;
                    (Controls.Find("pbDot" + i, true)[0] as PictureBox).Cursor = System.Windows.Forms.Cursors.Hand;
                }
                pbDisplay.Enabled = true;
                int[] Channels = new int[(6 / numChan)];
                for (int i = 0; i < 6 / numChan; i++)
                {
                    Channels[i] = currMeasure * 6 / numChan + i;
                }
                pbDot_MouseClick(pbDot1, e as MouseEventArgs);
                Send("PCtoPI", 3, "" + currMeasure);
                newChannel = new CChannel(Channels);
                dotInserted = 0;
                pnlNewStandard.Enabled = false;
                ((Control)tabPageConstant).Enabled = false;
                ((Control)tabPageStandard).Enabled = false;
            }
        }


        private void pbDot_MouseClick(object sender, MouseEventArgs e)
        {
            if (newAdvancedStarted)
            {
                var pbDot = sender as PictureBox;
                int n = pbDot.Name[5] - '0' - 1;
                if (currDot != null)
                {
                    currDot.Size = new Size(13, 13);
                    currDot.Location = new Point(currDot.Location.X + 3, currDot.Location.Y + 3);
                }
                nudPower.Enabled = true;
                pbDot.Size = new Size(19, 19);
                pbDot.Location = new Point(pbDot.Location.X - 3, pbDot.Location.Y - 3);
                currDotPos = new int[2] { (int)n / 3, n % 3 };
                currDot = pbDot;
                btnConfirmDot.Enabled = true;
                if(newChannel != null)
                    nudPower.Value = newChannel.Powers[currDotPos[0], currDotPos[1]];
                nudPower.Focus();
                nudPower.Select(0, nudPower.Text.Length);
            }      
        }

        private void btnConfirmDot_Click(object sender, EventArgs e)
        {
            newChannel.setPower(currDotPos[0], currDotPos[1], (int)nudPower.Value);
            currDot.Image = Simulatore_luce_solare.Properties.Resources.Green;
            int nextDot = (currDot.Name[5] - '0') % 6 + 1;
            pbDot_MouseClick(this.Controls.Find("pbDot" + nextDot, true)[0], e as MouseEventArgs);
            if (!valueInserted[currMeasure, currDotPos[1]*2 + currDotPos[0]])
            {
                valueInserted[currMeasure, currDotPos[1] * 2 + currDotPos[0]] = true;
                dotInserted++;
                if (dotInserted == 6)
                    btnNextAdvanced.Enabled = true;
            }
        }

        ToolTip ttDots = new ToolTip();
        private void pbDot_MouseEnter(object sender, EventArgs e)
        {
            if (!newAdvancedStarted)
            {
                var pbDot = sender as PictureBox;

                pbDot.Size = new Size(19, 19);
                pbDot.Location = new Point(pbDot.Location.X - 3, pbDot.Location.Y - 3);
                int n = pbDot.Name[5] - '0' - 1;

                ttDots.Show((cbChannels.SelectedItem as CChannel).Powers[n/3, n%3]+ "W/m2", this, this.PointToClient(System.Windows.Forms.Cursor.Position));
            }
        }

        private void pbDot_MouseLeave(object sender, EventArgs e)
        {
            if (!newAdvancedStarted)
            {
                var pbDot = sender as PictureBox;

                pbDot.Size = new Size(13, 13);
                pbDot.Location = new Point(pbDot.Location.X + 3, pbDot.Location.Y + 3);

                ttDots.RemoveAll();
            }
        }

        private void cbChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbChannels.SelectedItem == null)
            {
                cbChannels.Text = "--Select a channel--";
                for (int i = 0; i < 6; i++)
                {
                    var dot = Controls.Find("pbDot" + (i + 1), true)[0] as PictureBox;
                    dot.Enabled = false;

                }
                pbDisplay.Enabled = false;
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    var dot = Controls.Find("pbDot" + (i + 1), true)[0] as PictureBox;
                    dot.Enabled = true;
                }
                pbDisplay.Enabled = true;
            }
        }

        private void rbLandscape_CheckedChanged(object sender, EventArgs e)
        {
            if(rbLandscape.Checked)
            {
                if(Connected)
                    Send("PCtoPI", 1, "l");
                pbDisplay.Image = Simulatore_luce_solare.Properties.Resources.landscape;
                pbDisplay.Location = LandscapePoints[6];
                pbDisplay.Size = LandscapeSize;
                for (int i = 0; i < 6; i++)
                {
                    var dot = Controls.Find("pbDot" + (i + 1), true)[0] as PictureBox;
                    dot.Location = LandscapePoints[i];
                }
                cbChannels.Items.Clear();
                if(chanLandscape != null)
                {
                    foreach (CChannel c in chanLandscape)
                    {
                        cbChannels.Items.Add(c);
                    }
                }
                cbChannels.SelectedItem = null;
                cbChannels_SelectedIndexChanged(sender, e);
            }
        }

        private void rbPortrait_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPortrait.Checked)
            {
                if(Connected)
                    Send("PCtoPI", 1, "p");
                pbDisplay.Image = Simulatore_luce_solare.Properties.Resources.portrait;
                pbDisplay.Location = PortraitPoints[6];
                pbDisplay.Size = PortraitSize;
                for (int i = 0; i < 6; i++)
                {
                    var dot = Controls.Find("pbDot" + (i + 1), true)[0] as PictureBox;
                    dot.Location = PortraitPoints[i];
                }
                cbChannels.Items.Clear();
                if (chanPortrait != null)
                {
                    foreach (CChannel c in chanPortrait)
                    {
                        cbChannels.Items.Add(c);
                    }
                }
                cbChannels.SelectedItem = null;
                cbChannels_SelectedIndexChanged(sender, e);
            }
        }

        private int nDots;
        private void timerHeating_Tick(object sender, EventArgs e)
        {
            nDots = (nDots + 1) % 3 + 1;
            lblChart.Text = "Preheating of the spotlights in progress";
            for (int i = 0; i < nDots; i++)
                lblChart.Text += ".";
        }

        private void timerCooling_Tick(object sender, EventArgs e)
        {
            nDots = (nDots + 1) % 3 + 1;
            lblChart.Text = "Cooling of the spotlights in progress";
            for (int i = 0; i < nDots; i++)
                lblChart.Text += ".";
        }

        private void btnChooseChart_Click(object sender, EventArgs e)
        {
            if (ofdDay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    CDay newDay = new CDay(ofdDay.FileName);
                    Day = newDay;
                    lblError.Text = "";
                    lblLatitude.Text = "Latitude (decimal degrees): " + Day.Latitude;
                    lblLongitude.Text = "Longitude (decimal degrees): " + Day.Longitude;
                    lblSlope.Text = "Slope of plane (decimal degrees): " + Day.Slope;
                    lblMonth.Text = "Results for: " + Day.Month;
                    chart.ChartAreas[0].AxisX.Maximum = 24;
                    chart.ChartAreas[0].AxisX.Minimum = 0;
                    chart.ChartAreas[0].AxisY.Minimum = 0;
                    chart.ChartAreas[0].AxisY.Maximum = 1000;
                    chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chart.ChartAreas[0].AxisX.Interval = 3;
                    chart.ChartAreas[0].AxisY.Title = "Daily irradiance [W/m2]";
                    chart.ChartAreas[0].AxisX.Title = "Hours (UTC)";
                    chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                    chart.ChartAreas[0].AxisY.LineWidth = 0;
                    chart.ChartAreas[0].AxisY.MajorTickMark.LineWidth = 0;
                    chart.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.LightGray;
                    chart.ChartAreas[0].AxisX.MajorTickMark.Size = 3;
                    chart.ChartAreas[0].AxisX.LineColor = Color.LightGray;
                    var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Powers",
                        Color = System.Drawing.Color.DarkRed,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = false,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                    };

                    var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Start/End",
                        Color = System.Drawing.Color.LightGray,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = false,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
                    };
                    chart.Annotations.Clear();
                    VerticalLineAnnotation VA;
                    VA = new VerticalLineAnnotation();
                    VA.AxisX = chart.ChartAreas[0].AxisX;
                    VA.AllowMoving = false;
                    VA.IsInfinitive = true;
                    VA.ClipToChartArea = chart.ChartAreas[0].Name;
                    VA.Name = "Line2";
                    VA.LineColor = Color.LightGray;
                    VA.LineWidth = 1;
                    VA.X = 0;

                    chart.Annotations.Add(VA);

                    VerticalLineAnnotation VA2;
                    VA2 = new VerticalLineAnnotation();
                    VA2.AxisX = chart.ChartAreas[0].AxisX;
                    VA2.AllowMoving = false;
                    VA2.IsInfinitive = true;
                    VA2.ClipToChartArea = chart.ChartAreas[0].Name;
                    VA2.Name = "Line1";
                    VA2.LineColor = Color.LightGray;
                    VA2.LineWidth = 1;
                    VA2.X = 24;

                    chart.Annotations.Add(VA2);

                    chart.Series.Clear();
                    chart.Series.Add(series1);
                    series1.BorderWidth = 2;

                    for (int i = 0; i < Day.Points.Count; i++)
                    {
                        series1.Points.Add(Day.Points[i]);
                    }
                    series1.Points.AddXY(23.99, Day.Points[0].YValues[0]);

                    chart.Series.Add(series2);
                    chart.Series[1].Points.AddXY(0, 0);
                    chart.Series[1].Points.AddXY(23.99, 0);
                    foreach (DataPoint p in chart.Series[1].Points)
                    {
                        p.MarkerStyle = MarkerStyle.Diamond;
                        p.MarkerSize = 15;
                        p.MarkerColor = Color.LightGray;
                        p.BorderColor = Color.Gray;
                    }

       
                    dtpStart.Enabled = true;
                    dtpEnd.Enabled = true;
                    if (Connected)
                    {
                        if (SimulationOn == 1)
                            btnResetSimulation.Enabled = true;
                        else if (SimulationOn == -1)
                            btnLoadSimulation.Enabled = true;


                    }

                    lblChart.Visible = false;
                    cbTime.Enabled = true;
                    if (cbTime.Checked)
                    {
                        nudHours.Enabled = true;
                        nudMinutes.Enabled = true;
                    }
                    dtpStart.Value = new DateTime(2000, 1, 1, 0, 0, 00);
                    dtpEnd.Value = new DateTime(2000, 1, 1, 23, 59, 00);

                }
                catch (Exception)
                {
                    lblError.Text = "File not supported!";
                }

            }
        }

        private void cbChannels_Leave(object sender, EventArgs e)
        {
            if (cbChannels.SelectedItem == null)
            {
                cbChannels.Text = "--Select a channel--";
                for (int i = 0; i < 6; i++)
                {
                    var dot = Controls.Find("pbDot" + (i + 1), true)[0] as PictureBox;
                    dot.Enabled = false;

                }
                pbDisplay.Enabled = false;
            }
        }

        private void pb_EnabledChanged(object sender, EventArgs e)
        {
            (sender as Control).Invalidate();
        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            if((sender as Control).Enabled == false)
            {
                Color control = Color.FromKnownColor(KnownColor.Control);
                using (Brush fBrush = new SolidBrush(Color.FromArgb(171, control.R, control.G, control.B)))
                    e.Graphics.FillRectangle(fBrush, (sender as Control).ClientRectangle);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newAdvancedStarted)
            {
                if (MessageBox.Show("Are you sure you want to interrupt the calibration?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Send("PCtoPI", 1, "r");
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (newStandardStarted)
            {
                if (MessageBox.Show("Are you sure you want to interrupt the calibration?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Send("PCtoPI", 1, "r");
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (SimulationOn == 1)
            {
                if (MessageBox.Show("Closing the application won't interrupt the simulation but information about it won't be available anymore. Close the application?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (nudHours.Value * 60 + nudMinutes.Value < 60)
            {
                nudHours.Value = 1;
                nudMinutes.Value = 0;
            }
        }

        private void btnNewStandard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Start a new calibration of the channels?", "NEW CALIBRATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                newStandardStarted = true;
                lblAdvise.Visible = true;
                lblStandard.Text = "Regulate the channels level until" + Environment.NewLine + "about 600W/m2 are measured almost" + Environment.NewLine + "everywhere on the display...";
                btnCancel.Enabled = true;
                pnlNewAdvanced.Enabled = false;
                pnlDisplay.Enabled = false;
                btnNewStandard.Enabled = false;
                btnSave.Enabled = true;
                pnlSliders.Enabled = true;
                (tabPageConstant as Control).Enabled = false;
                (tabPageSimulation as Control).Enabled = false;
                string message = "";
                for (int i = 1; i < 7; i++)
                {
                    message += (this.Controls.Find("ucSlider" + i, true)[0] as ucSlider).Value + ";";
                }
                Send("PCtoPI", 4, message);
            }
        }


        private void ResetNewStandardPanel()
        {
            newStandardStarted = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            lblStandard.Text =  "Select 'New calibration' to start a" + Environment.NewLine + "new regulation of the channels";
            lblAdvise.Visible = false;
            pnlNewAdvanced.Enabled = false;
            pnlDisplay.Enabled = true;
            pnlNewStandard.Enabled = true;
            btnNewStandard.Enabled = true;
            (tabPageSimulation as Control).Enabled = true;
            (tabPageConstant as Control).Enabled = true;
            pnlSliders.Enabled = false;
        }


        public void SlidersModified()
        {
            if (newStandardStarted)
            {
                string message = "";
                for (int i = 1; i < 7; i++)
                {
                    message += (this.Controls.Find("ucSlider" + i, true)[0] as ucSlider).Value + ";";
                }
                Send("PCtoPI", 4, message);
            }
            else if(ConstantOn && cbAllow.Checked)
            {
                string message = "";
                for (int i = 1; i < 7; i++)
                {
                    message += (this.Controls.Find("ucSliderConstant" + i, true)[0] as ucSlider).Value + ";";
                }
                Send("PCtoPI", 6, message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Send("PCtoPI", 1, "r");

            for (int i = 1; i < 7; i++)
            {
                (this.Controls.Find("ucSlider" + i, true)[0] as ucSlider).Value = Standard.Values[i - 1];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Overwrite the old calibration with the newly created one?", "", MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Cancel)
                return;
            if (d == DialogResult.Yes)
            {
                string message = "";
                for (int i = 1; i < 7; i++)
                {
                    Standard.Values[i - 1] = (this.Controls.Find("ucSlider" + i, true)[0] as ucSlider).Value;
                    message += Standard.Values[i - 1] + ";";
                }
                Send("PCtoPI", 5, message);
            }
            Send("PCtoPI", 1, "r");
        }

        private void nudPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                btnConfirmDot_Click(sender, e);
        }

        private void rbStandard_Click(object sender, EventArgs e)
        {
            if (rbStandard1.Checked || rbStandard2.Checked)
            {
                rbStandard1.Checked = true;
                rbStandard2.Checked = true;
                if (SimulationOn == -1)
                {
                    pnlNewStandard.Enabled = true;
                    pnlNewAdvanced.Enabled = false;
                    pnlDisplay.Enabled = true;
                    Send("PCtoPI", 1, "st");
                }
            }
        }

        private void rbAdvanced_Click(object sender, EventArgs e)
        {
            if (rbAdvanced1.Checked || rbAdvanced2.Checked)
            {
                rbAdvanced1.Checked = true;
                rbAdvanced2.Checked = true;
                if (SimulationOn == -1)
                {
                    pnlNewAdvanced.Enabled = true;
                    pnlNewStandard.Enabled = false;
                    pnlDisplay.Enabled = true;
                    Send("PCtoPI", 1, "ad");
                }

            }
        }

        private void cbAllow_Click(object sender, EventArgs e)
        {
            if (cbAllow.Checked)
            {
                pnlSlidersConstant.Enabled = true;
            }
            else
            {
                pnlSlidersConstant.Enabled = false;
                string message = "";
                for (int i = 0; i < 6; i++)
                {
                    message += chanLevelsConstant[i] + ";";
                    (this.Controls.Find("ucSliderConstant" + (i + 1), true)[0] as ucSlider).Value = chanLevelsConstant[i];
                }
                Send("PCtoPI", 6, message);
            }
        }

        private void nudHoursConstant_ValueChanged(object sender, EventArgs e)
        {
            hConstant = (int)nudHoursConstant.Value + (int)nudMinutesConstant.Value/60;
            mConstant = ((int)nudHoursConstant.Value * 60 + (int)nudMinutesConstant.Value) - hConstant * 60;
            string mString = mConstant+"";
            if (mConstant < 10)
                mString = "0" + mString;
            lblTime.Text = hConstant + ":" + mString;
        }

        private void nudMinutesConstant_ValueChanged(object sender, EventArgs e)
        {
            hConstant = (int)nudHoursConstant.Value + (int)nudMinutesConstant.Value / 60;
            mConstant = ((int)nudHoursConstant.Value * 60 + (int)nudMinutesConstant.Value) - hConstant * 60;
            string mString = mConstant + "";
            if (mConstant < 10)
                mString = "0" + mString;
            lblTime.Text = hConstant + ":" + mString;
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            formIP.ShowDialog();
        }
    }
}
