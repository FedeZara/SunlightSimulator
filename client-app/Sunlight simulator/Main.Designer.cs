namespace Simulatore_luce_solare
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.ofdDay = new System.Windows.Forms.OpenFileDialog();
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.timerSimulation = new System.Windows.Forms.Timer(this.components);
            this.timerHeating = new System.Windows.Forms.Timer(this.components);
            this.timerCooling = new System.Windows.Forms.Timer(this.components);
            this.tabPageStandard = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnlNewStandard = new System.Windows.Forms.Panel();
            this.btnNewStandard = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStandard = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnIP3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbConnection3 = new System.Windows.Forms.PictureBox();
            this.lblConnected3 = new System.Windows.Forms.Label();
            this.pnlSliders = new System.Windows.Forms.Panel();
            this.lblAdvise = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPageSimulation = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMode2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMode2 = new System.Windows.Forms.Label();
            this.rbAdvanced2 = new System.Windows.Forms.RadioButton();
            this.rbStandard2 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnIP2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblConnected2 = new System.Windows.Forms.Label();
            this.pbConnection2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChart = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnResetSimulation = new System.Windows.Forms.Button();
            this.btnLoadSimulation = new System.Windows.Forms.Button();
            this.btnChooseChart = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.lblHour = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblSlope = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConstant = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlPower = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.nudPowerConstant = new System.Windows.Forms.NumericUpDown();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnLoadConstant = new System.Windows.Forms.Button();
            this.btnResetConstant = new System.Windows.Forms.Button();
            this.pnlDuration = new System.Windows.Forms.Panel();
            this.nudMinutesConstant = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudHoursConstant = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlMode1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lblMode1 = new System.Windows.Forms.Label();
            this.rbAdvanced1 = new System.Windows.Forms.RadioButton();
            this.rbStandard1 = new System.Windows.Forms.RadioButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnIP1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblConnected1 = new System.Windows.Forms.Label();
            this.pbConnection1 = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.cbAllow = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlSlidersConstant = new System.Windows.Forms.Panel();
            this.tabPageAdvanced = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.rbPortrait = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbLandscape = new System.Windows.Forms.RadioButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnIP4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pbConnection4 = new System.Windows.Forms.PictureBox();
            this.lblConnected4 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pbDot1 = new System.Windows.Forms.PictureBox();
            this.cbChannels = new System.Windows.Forms.ComboBox();
            this.pbDot4 = new System.Windows.Forms.PictureBox();
            this.btnConfirmDot = new System.Windows.Forms.Button();
            this.pbDot2 = new System.Windows.Forms.PictureBox();
            this.nudPower = new System.Windows.Forms.NumericUpDown();
            this.pbDot3 = new System.Windows.Forms.PictureBox();
            this.pbDot5 = new System.Windows.Forms.PictureBox();
            this.pbDot6 = new System.Windows.Forms.PictureBox();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.pnlNewAdvanced = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbNewAdvanced = new System.Windows.Forms.ProgressBar();
            this.lblCurrChannel = new System.Windows.Forms.Label();
            this.lblAdvanced = new System.Windows.Forms.Label();
            this.btnNextAdvanced = new System.Windows.Forms.Button();
            this.btnNewAdvanced = new System.Windows.Forms.Button();
            this.btnCancelNewAdvanced = new System.Windows.Forms.Button();
            this.btnSaveNewAdvanced = new System.Windows.Forms.Button();
            this.btnPreviousAdvanced = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.ucSliderConstant6 = new Simulatore_luce_solare.ucSlider();
            this.ucSliderConstant5 = new Simulatore_luce_solare.ucSlider();
            this.ucSliderConstant4 = new Simulatore_luce_solare.ucSlider();
            this.ucSliderConstant3 = new Simulatore_luce_solare.ucSlider();
            this.ucSliderConstant2 = new Simulatore_luce_solare.ucSlider();
            this.ucSliderConstant1 = new Simulatore_luce_solare.ucSlider();
            this.ucSlider1 = new Simulatore_luce_solare.ucSlider();
            this.ucSlider2 = new Simulatore_luce_solare.ucSlider();
            this.ucSlider3 = new Simulatore_luce_solare.ucSlider();
            this.ucSlider4 = new Simulatore_luce_solare.ucSlider();
            this.ucSlider5 = new Simulatore_luce_solare.ucSlider();
            this.ucSlider6 = new Simulatore_luce_solare.ucSlider();
            this.tabPageStandard.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnlNewStandard.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection3)).BeginInit();
            this.pnlSliders.SuspendLayout();
            this.tabPageSimulation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMode2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageConstant.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPowerConstant)).BeginInit();
            this.panel16.SuspendLayout();
            this.pnlDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursConstant)).BeginInit();
            this.pnlMode1.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection1)).BeginInit();
            this.panel14.SuspendLayout();
            this.pnlSlidersConstant.SuspendLayout();
            this.tabPageAdvanced.SuspendLayout();
            this.panel.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection4)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.pnlNewAdvanced.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdDay
            // 
            this.ofdDay.FileName = "openFileDialog1";
            // 
            // timerConnection
            // 
            this.timerConnection.Enabled = true;
            this.timerConnection.Interval = 1000;
            this.timerConnection.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerSimulation
            // 
            this.timerSimulation.Interval = 60000;
            this.timerSimulation.Tick += new System.EventHandler(this.timerSimulation_Tick);
            // 
            // timerHeating
            // 
            this.timerHeating.Interval = 1000;
            this.timerHeating.Tick += new System.EventHandler(this.timerHeating_Tick);
            // 
            // timerCooling
            // 
            this.timerCooling.Interval = 1000;
            this.timerCooling.Tick += new System.EventHandler(this.timerCooling_Tick);
            // 
            // tabPageStandard
            // 
            this.tabPageStandard.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageStandard.Controls.Add(this.panel10);
            this.tabPageStandard.Location = new System.Drawing.Point(4, 31);
            this.tabPageStandard.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageStandard.Name = "tabPageStandard";
            this.tabPageStandard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStandard.Size = new System.Drawing.Size(799, 440);
            this.tabPageStandard.TabIndex = 4;
            this.tabPageStandard.Text = "Calibration (Standard)";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel10.Controls.Add(this.pnlNewStandard);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Controls.Add(this.pnlSliders);
            this.panel10.Location = new System.Drawing.Point(0, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(797, 439);
            this.panel10.TabIndex = 11;
            // 
            // pnlNewStandard
            // 
            this.pnlNewStandard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNewStandard.Controls.Add(this.btnNewStandard);
            this.pnlNewStandard.Controls.Add(this.btnCancel);
            this.pnlNewStandard.Controls.Add(this.btnSave);
            this.pnlNewStandard.Controls.Add(this.lblStandard);
            this.pnlNewStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNewStandard.Location = new System.Drawing.Point(6, 140);
            this.pnlNewStandard.Name = "pnlNewStandard";
            this.pnlNewStandard.Size = new System.Drawing.Size(252, 212);
            this.pnlNewStandard.TabIndex = 18;
            // 
            // btnNewStandard
            // 
            this.btnNewStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStandard.Location = new System.Drawing.Point(44, 32);
            this.btnNewStandard.Name = "btnNewStandard";
            this.btnNewStandard.Size = new System.Drawing.Size(159, 30);
            this.btnNewStandard.TabIndex = 11;
            this.btnNewStandard.Text = "New calibration";
            this.btnNewStandard.UseVisualStyleBackColor = true;
            this.btnNewStandard.Click += new System.EventHandler(this.btnNewStandard_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(39, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(137, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.Location = new System.Drawing.Point(36, 85);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(187, 30);
            this.lblStandard.TabIndex = 12;
            this.lblStandard.Text = "Select \'New calibration\' to start a \r\nnew regulation of the channels";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.btnIP3);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.pbConnection3);
            this.panel7.Controls.Add(this.lblConnected3);
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(204, 61);
            this.panel7.TabIndex = 10;
            // 
            // btnIP3
            // 
            this.btnIP3.BackgroundImage = global::Simulatore_luce_solare.Properties.Resources._87756_gear_512x512;
            this.btnIP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIP3.Location = new System.Drawing.Point(168, 18);
            this.btnIP3.Name = "btnIP3";
            this.btnIP3.Size = new System.Drawing.Size(25, 25);
            this.btnIP3.TabIndex = 12;
            this.btnIP3.UseMnemonic = false;
            this.btnIP3.UseVisualStyleBackColor = true;
            this.btnIP3.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "State:";
            // 
            // pbConnection3
            // 
            this.pbConnection3.BackColor = System.Drawing.SystemColors.Control;
            this.pbConnection3.Image = ((System.Drawing.Image)(resources.GetObject("pbConnection3.Image")));
            this.pbConnection3.Location = new System.Drawing.Point(57, 22);
            this.pbConnection3.Name = "pbConnection3";
            this.pbConnection3.Size = new System.Drawing.Size(11, 17);
            this.pbConnection3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConnection3.TabIndex = 9;
            this.pbConnection3.TabStop = false;
            this.pbConnection3.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbConnection3.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // lblConnected3
            // 
            this.lblConnected3.AutoSize = true;
            this.lblConnected3.BackColor = System.Drawing.SystemColors.Control;
            this.lblConnected3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected3.ForeColor = System.Drawing.Color.Red;
            this.lblConnected3.Location = new System.Drawing.Point(70, 22);
            this.lblConnected3.Name = "lblConnected3";
            this.lblConnected3.Size = new System.Drawing.Size(95, 16);
            this.lblConnected3.TabIndex = 8;
            this.lblConnected3.Text = "Not connected";
            // 
            // pnlSliders
            // 
            this.pnlSliders.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSliders.Controls.Add(this.ucSlider1);
            this.pnlSliders.Controls.Add(this.ucSlider2);
            this.pnlSliders.Controls.Add(this.ucSlider3);
            this.pnlSliders.Controls.Add(this.ucSlider4);
            this.pnlSliders.Controls.Add(this.ucSlider5);
            this.pnlSliders.Controls.Add(this.lblAdvise);
            this.pnlSliders.Controls.Add(this.ucSlider6);
            this.pnlSliders.Controls.Add(this.label17);
            this.pnlSliders.Enabled = false;
            this.pnlSliders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSliders.Location = new System.Drawing.Point(264, 5);
            this.pnlSliders.Name = "pnlSliders";
            this.pnlSliders.Size = new System.Drawing.Size(529, 428);
            this.pnlSliders.TabIndex = 8;
            // 
            // lblAdvise
            // 
            this.lblAdvise.AutoSize = true;
            this.lblAdvise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvise.ForeColor = System.Drawing.Color.Red;
            this.lblAdvise.Location = new System.Drawing.Point(54, 399);
            this.lblAdvise.Name = "lblAdvise";
            this.lblAdvise.Size = new System.Drawing.Size(427, 15);
            this.lblAdvise.TabIndex = 15;
            this.lblAdvise.Text = "NOTE: You have to reach 600W/m2 in order to calibrate the channels properly";
            this.lblAdvise.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(67, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "Channels regulation";
            // 
            // tabPageSimulation
            // 
            this.tabPageSimulation.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageSimulation.Controls.Add(this.panel1);
            this.tabPageSimulation.Location = new System.Drawing.Point(4, 31);
            this.tabPageSimulation.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageSimulation.Name = "tabPageSimulation";
            this.tabPageSimulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSimulation.Size = new System.Drawing.Size(799, 440);
            this.tabPageSimulation.TabIndex = 0;
            this.tabPageSimulation.Text = "Daily solar irradiance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pnlMode2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 439);
            this.panel1.TabIndex = 7;
            // 
            // pnlMode2
            // 
            this.pnlMode2.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMode2.Controls.Add(this.label19);
            this.pnlMode2.Controls.Add(this.lblMode2);
            this.pnlMode2.Controls.Add(this.rbAdvanced2);
            this.pnlMode2.Controls.Add(this.rbStandard2);
            this.pnlMode2.Location = new System.Drawing.Point(215, 5);
            this.pnlMode2.Name = "pnlMode2";
            this.pnlMode2.Size = new System.Drawing.Size(330, 61);
            this.pnlMode2.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(13, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(248, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "NOTE: Every new setup requires a new calibration.";
            // 
            // lblMode2
            // 
            this.lblMode2.AutoSize = true;
            this.lblMode2.Location = new System.Drawing.Point(13, 14);
            this.lblMode2.Name = "lblMode2";
            this.lblMode2.Size = new System.Drawing.Size(122, 16);
            this.lblMode2.TabIndex = 13;
            this.lblMode2.Text = "Type of calibration:";
            // 
            // rbAdvanced2
            // 
            this.rbAdvanced2.AutoSize = true;
            this.rbAdvanced2.Location = new System.Drawing.Point(228, 12);
            this.rbAdvanced2.Name = "rbAdvanced2";
            this.rbAdvanced2.Size = new System.Drawing.Size(88, 20);
            this.rbAdvanced2.TabIndex = 12;
            this.rbAdvanced2.Text = "Advanced";
            this.rbAdvanced2.UseVisualStyleBackColor = true;
            this.rbAdvanced2.Click += new System.EventHandler(this.rbAdvanced_Click);
            // 
            // rbStandard2
            // 
            this.rbStandard2.AutoSize = true;
            this.rbStandard2.Checked = true;
            this.rbStandard2.Location = new System.Drawing.Point(141, 12);
            this.rbStandard2.Name = "rbStandard2";
            this.rbStandard2.Size = new System.Drawing.Size(81, 20);
            this.rbStandard2.TabIndex = 12;
            this.rbStandard2.TabStop = true;
            this.rbStandard2.Text = "Standard";
            this.rbStandard2.UseVisualStyleBackColor = true;
            this.rbStandard2.Click += new System.EventHandler(this.rbStandard_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.btnIP2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lblConnected2);
            this.panel5.Controls.Add(this.pbConnection2);
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 61);
            this.panel5.TabIndex = 11;
            // 
            // btnIP2
            // 
            this.btnIP2.BackgroundImage = global::Simulatore_luce_solare.Properties.Resources._87756_gear_512x512;
            this.btnIP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIP2.Location = new System.Drawing.Point(168, 18);
            this.btnIP2.Name = "btnIP2";
            this.btnIP2.Size = new System.Drawing.Size(25, 25);
            this.btnIP2.TabIndex = 11;
            this.btnIP2.UseMnemonic = false;
            this.btnIP2.UseVisualStyleBackColor = true;
            this.btnIP2.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "State:";
            // 
            // lblConnected2
            // 
            this.lblConnected2.AutoSize = true;
            this.lblConnected2.BackColor = System.Drawing.SystemColors.Control;
            this.lblConnected2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected2.ForeColor = System.Drawing.Color.Red;
            this.lblConnected2.Location = new System.Drawing.Point(70, 22);
            this.lblConnected2.Name = "lblConnected2";
            this.lblConnected2.Size = new System.Drawing.Size(95, 16);
            this.lblConnected2.TabIndex = 8;
            this.lblConnected2.Text = "Not connected";
            // 
            // pbConnection2
            // 
            this.pbConnection2.BackColor = System.Drawing.SystemColors.Control;
            this.pbConnection2.Image = ((System.Drawing.Image)(resources.GetObject("pbConnection2.Image")));
            this.pbConnection2.Location = new System.Drawing.Point(57, 22);
            this.pbConnection2.Name = "pbConnection2";
            this.pbConnection2.Size = new System.Drawing.Size(11, 17);
            this.pbConnection2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConnection2.TabIndex = 9;
            this.pbConnection2.TabStop = false;
            this.pbConnection2.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbConnection2.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblChart);
            this.panel4.Controls.Add(this.lblError);
            this.panel4.Controls.Add(this.btnResetSimulation);
            this.panel4.Controls.Add(this.btnLoadSimulation);
            this.panel4.Controls.Add(this.btnChooseChart);
            this.panel4.Controls.Add(this.chart);
            this.panel4.Location = new System.Drawing.Point(5, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 361);
            this.panel4.TabIndex = 9;
            // 
            // chart
            // 
            this.chart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(10, 15);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(516, 300);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            this.chart.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.chart.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_MouseDown);
            this.chart.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            this.chart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart_MouseUp);
            // 
            // lblChart
            // 
            this.lblChart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblChart.BackColor = System.Drawing.Color.White;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.lblChart.Location = new System.Drawing.Point(9, 15);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(517, 300);
            this.lblChart.TabIndex = 11;
            this.lblChart.Text = "No chart imported";
            this.lblChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(139, 333);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // btnResetSimulation
            // 
            this.btnResetSimulation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetSimulation.AutoSize = true;
            this.btnResetSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSimulation.Location = new System.Drawing.Point(381, 326);
            this.btnResetSimulation.Name = "btnResetSimulation";
            this.btnResetSimulation.Size = new System.Drawing.Size(142, 26);
            this.btnResetSimulation.TabIndex = 1;
            this.btnResetSimulation.Text = "Stop simulation";
            this.btnResetSimulation.UseVisualStyleBackColor = true;
            this.btnResetSimulation.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoadSimulation
            // 
            this.btnLoadSimulation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoadSimulation.AutoSize = true;
            this.btnLoadSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSimulation.Location = new System.Drawing.Point(253, 326);
            this.btnLoadSimulation.Name = "btnLoadSimulation";
            this.btnLoadSimulation.Size = new System.Drawing.Size(122, 26);
            this.btnLoadSimulation.TabIndex = 1;
            this.btnLoadSimulation.Text = "Start simulation";
            this.btnLoadSimulation.UseVisualStyleBackColor = true;
            this.btnLoadSimulation.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnChooseChart
            // 
            this.btnChooseChart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChooseChart.AutoSize = true;
            this.btnChooseChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseChart.Location = new System.Drawing.Point(23, 326);
            this.btnChooseChart.Name = "btnChooseChart";
            this.btnChooseChart.Size = new System.Drawing.Size(110, 26);
            this.btnChooseChart.TabIndex = 1;
            this.btnChooseChart.Text = "Choose chart";
            this.btnChooseChart.UseVisualStyleBackColor = true;
            this.btnChooseChart.Click += new System.EventHandler(this.btnChooseChart_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "HH:mm";
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(680, 206);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(66, 20);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "HH:mm";
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(680, 233);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(66, 20);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.Value = new System.DateTime(2000, 1, 1, 23, 59, 0, 0);
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(575, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(581, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Simulation interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(575, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ending time: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.cbTime);
            this.panel2.Controls.Add(this.nudMinutes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblMinute);
            this.panel2.Controls.Add(this.nudHours);
            this.panel2.Controls.Add(this.lblHour);
            this.panel2.Location = new System.Drawing.Point(551, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 143);
            this.panel2.TabIndex = 7;
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.Location = new System.Drawing.Point(27, 45);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(102, 17);
            this.cbTime.TabIndex = 7;
            this.cbTime.Text = "Custom duration";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Enabled = false;
            this.nudMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutes.Location = new System.Drawing.Point(75, 103);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(62, 20);
            this.nudMinutes.TabIndex = 6;
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Simulation duration";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Enabled = false;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(24, 105);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(47, 13);
            this.lblMinute.TabIndex = 2;
            this.lblMinute.Text = "Minutes:";
            // 
            // nudHours
            // 
            this.nudHours.Enabled = false;
            this.nudHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHours.Location = new System.Drawing.Point(75, 69);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(62, 20);
            this.nudHours.TabIndex = 6;
            this.nudHours.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Enabled = false;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(24, 71);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(38, 13);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Hours:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblLatitude);
            this.panel3.Controls.Add(this.lblSlope);
            this.panel3.Controls.Add(this.lblMonth);
            this.panel3.Controls.Add(this.lblLongitude);
            this.panel3.Location = new System.Drawing.Point(551, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 154);
            this.panel3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Chart information";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(24, 50);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(134, 13);
            this.lblLatitude.TabIndex = 2;
            this.lblLatitude.Text = "Latitude (decimal degrees):";
            // 
            // lblSlope
            // 
            this.lblSlope.AutoSize = true;
            this.lblSlope.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlope.Location = new System.Drawing.Point(24, 119);
            this.lblSlope.Name = "lblSlope";
            this.lblSlope.Size = new System.Drawing.Size(167, 13);
            this.lblSlope.TabIndex = 2;
            this.lblSlope.Text = "Slope of plane (decimal degrees): ";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(24, 96);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(63, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Results for: ";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(24, 73);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(143, 13);
            this.lblLongitude.TabIndex = 2;
            this.lblLongitude.Text = "Longitude (decimal degrees):";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageConstant);
            this.tabControl.Controls.Add(this.tabPageSimulation);
            this.tabControl.Controls.Add(this.tabPageStandard);
            this.tabControl.Controls.Add(this.tabPageAdvanced);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(6, 6);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(807, 475);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageConstant
            // 
            this.tabPageConstant.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageConstant.Controls.Add(this.panel8);
            this.tabPageConstant.Location = new System.Drawing.Point(4, 31);
            this.tabPageConstant.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageConstant.Name = "tabPageConstant";
            this.tabPageConstant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConstant.Size = new System.Drawing.Size(799, 440);
            this.tabPageConstant.TabIndex = 6;
            this.tabPageConstant.Text = "Constant solar irradiance";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.pnlPower);
            this.panel8.Controls.Add(this.panel16);
            this.panel8.Controls.Add(this.pnlDuration);
            this.panel8.Controls.Add(this.pnlMode1);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Location = new System.Drawing.Point(0, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(797, 439);
            this.panel8.TabIndex = 7;
            // 
            // pnlPower
            // 
            this.pnlPower.Controls.Add(this.label18);
            this.pnlPower.Controls.Add(this.nudPowerConstant);
            this.pnlPower.Location = new System.Drawing.Point(588, 165);
            this.pnlPower.Name = "pnlPower";
            this.pnlPower.Size = new System.Drawing.Size(205, 111);
            this.pnlPower.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(33, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Target [W/m2]:";
            // 
            // nudPowerConstant
            // 
            this.nudPowerConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPowerConstant.Location = new System.Drawing.Point(37, 54);
            this.nudPowerConstant.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudPowerConstant.Name = "nudPowerConstant";
            this.nudPowerConstant.Size = new System.Drawing.Size(75, 26);
            this.nudPowerConstant.TabIndex = 16;
            this.nudPowerConstant.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.Control;
            this.panel16.Controls.Add(this.lblTime);
            this.panel16.Controls.Add(this.label);
            this.panel16.Controls.Add(this.btnLoadConstant);
            this.panel16.Controls.Add(this.btnResetConstant);
            this.panel16.Location = new System.Drawing.Point(588, 282);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(205, 119);
            this.panel16.TabIndex = 14;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(128, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 31);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "1:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(26, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 16);
            this.label.TabIndex = 16;
            this.label.Text = "Remaining time:";
            // 
            // btnLoadConstant
            // 
            this.btnLoadConstant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoadConstant.AutoSize = true;
            this.btnLoadConstant.Enabled = false;
            this.btnLoadConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadConstant.Location = new System.Drawing.Point(37, 46);
            this.btnLoadConstant.Name = "btnLoadConstant";
            this.btnLoadConstant.Size = new System.Drawing.Size(125, 26);
            this.btnLoadConstant.TabIndex = 15;
            this.btnLoadConstant.Text = "Start simulation";
            this.btnLoadConstant.UseVisualStyleBackColor = true;
            this.btnLoadConstant.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnResetConstant
            // 
            this.btnResetConstant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetConstant.AutoSize = true;
            this.btnResetConstant.Enabled = false;
            this.btnResetConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetConstant.Location = new System.Drawing.Point(37, 78);
            this.btnResetConstant.Name = "btnResetConstant";
            this.btnResetConstant.Size = new System.Drawing.Size(125, 26);
            this.btnResetConstant.TabIndex = 14;
            this.btnResetConstant.Text = "Stop simulation";
            this.btnResetConstant.UseVisualStyleBackColor = true;
            this.btnResetConstant.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlDuration
            // 
            this.pnlDuration.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDuration.Controls.Add(this.nudMinutesConstant);
            this.pnlDuration.Controls.Add(this.label10);
            this.pnlDuration.Controls.Add(this.label12);
            this.pnlDuration.Controls.Add(this.nudHoursConstant);
            this.pnlDuration.Controls.Add(this.label16);
            this.pnlDuration.Location = new System.Drawing.Point(588, 40);
            this.pnlDuration.Name = "pnlDuration";
            this.pnlDuration.Size = new System.Drawing.Size(205, 119);
            this.pnlDuration.TabIndex = 13;
            // 
            // nudMinutesConstant
            // 
            this.nudMinutesConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutesConstant.Location = new System.Drawing.Point(81, 81);
            this.nudMinutesConstant.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudMinutesConstant.Name = "nudMinutesConstant";
            this.nudMinutesConstant.Size = new System.Drawing.Size(62, 20);
            this.nudMinutesConstant.TabIndex = 6;
            this.nudMinutesConstant.ValueChanged += new System.EventHandler(this.nudMinutesConstant_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Simulation duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Minutes:";
            // 
            // nudHoursConstant
            // 
            this.nudHoursConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHoursConstant.Location = new System.Drawing.Point(81, 47);
            this.nudHoursConstant.Name = "nudHoursConstant";
            this.nudHoursConstant.Size = new System.Drawing.Size(62, 20);
            this.nudHoursConstant.TabIndex = 6;
            this.nudHoursConstant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHoursConstant.ValueChanged += new System.EventHandler(this.nudHoursConstant_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(30, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Hours:";
            // 
            // pnlMode1
            // 
            this.pnlMode1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMode1.Controls.Add(this.label20);
            this.pnlMode1.Controls.Add(this.lblMode1);
            this.pnlMode1.Controls.Add(this.rbAdvanced1);
            this.pnlMode1.Controls.Add(this.rbStandard1);
            this.pnlMode1.Enabled = false;
            this.pnlMode1.Location = new System.Drawing.Point(215, 5);
            this.pnlMode1.Name = "pnlMode1";
            this.pnlMode1.Size = new System.Drawing.Size(364, 61);
            this.pnlMode1.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(13, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(248, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "NOTE: Every new setup requires a new calibration.";
            // 
            // lblMode1
            // 
            this.lblMode1.AutoSize = true;
            this.lblMode1.Location = new System.Drawing.Point(13, 14);
            this.lblMode1.Name = "lblMode1";
            this.lblMode1.Size = new System.Drawing.Size(122, 16);
            this.lblMode1.TabIndex = 13;
            this.lblMode1.Text = "Type of calibration:";
            // 
            // rbAdvanced1
            // 
            this.rbAdvanced1.AutoSize = true;
            this.rbAdvanced1.Location = new System.Drawing.Point(268, 12);
            this.rbAdvanced1.Name = "rbAdvanced1";
            this.rbAdvanced1.Size = new System.Drawing.Size(88, 20);
            this.rbAdvanced1.TabIndex = 12;
            this.rbAdvanced1.Text = "Advanced";
            this.rbAdvanced1.UseVisualStyleBackColor = true;
            this.rbAdvanced1.Click += new System.EventHandler(this.rbAdvanced_Click);
            // 
            // rbStandard1
            // 
            this.rbStandard1.AutoSize = true;
            this.rbStandard1.Checked = true;
            this.rbStandard1.Location = new System.Drawing.Point(181, 12);
            this.rbStandard1.Name = "rbStandard1";
            this.rbStandard1.Size = new System.Drawing.Size(81, 20);
            this.rbStandard1.TabIndex = 12;
            this.rbStandard1.TabStop = true;
            this.rbStandard1.Text = "Standard";
            this.rbStandard1.UseVisualStyleBackColor = true;
            this.rbStandard1.Click += new System.EventHandler(this.rbStandard_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Control;
            this.panel12.Controls.Add(this.btnIP1);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.lblConnected1);
            this.panel12.Controls.Add(this.pbConnection1);
            this.panel12.Location = new System.Drawing.Point(5, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(204, 61);
            this.panel12.TabIndex = 11;
            // 
            // btnIP1
            // 
            this.btnIP1.BackgroundImage = global::Simulatore_luce_solare.Properties.Resources._87756_gear_512x512;
            this.btnIP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIP1.Location = new System.Drawing.Point(168, 18);
            this.btnIP1.Name = "btnIP1";
            this.btnIP1.Size = new System.Drawing.Size(25, 25);
            this.btnIP1.TabIndex = 8;
            this.btnIP1.UseMnemonic = false;
            this.btnIP1.UseVisualStyleBackColor = true;
            this.btnIP1.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "State:";
            // 
            // lblConnected1
            // 
            this.lblConnected1.AutoSize = true;
            this.lblConnected1.BackColor = System.Drawing.SystemColors.Control;
            this.lblConnected1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected1.ForeColor = System.Drawing.Color.Red;
            this.lblConnected1.Location = new System.Drawing.Point(70, 22);
            this.lblConnected1.Name = "lblConnected1";
            this.lblConnected1.Size = new System.Drawing.Size(95, 16);
            this.lblConnected1.TabIndex = 8;
            this.lblConnected1.Text = "Not connected";
            // 
            // pbConnection1
            // 
            this.pbConnection1.BackColor = System.Drawing.SystemColors.Control;
            this.pbConnection1.Image = ((System.Drawing.Image)(resources.GetObject("pbConnection1.Image")));
            this.pbConnection1.Location = new System.Drawing.Point(57, 22);
            this.pbConnection1.Name = "pbConnection1";
            this.pbConnection1.Size = new System.Drawing.Size(11, 17);
            this.pbConnection1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConnection1.TabIndex = 9;
            this.pbConnection1.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.Control;
            this.panel14.Controls.Add(this.cbAllow);
            this.panel14.Controls.Add(this.label15);
            this.panel14.Controls.Add(this.pnlSlidersConstant);
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(5, 72);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(574, 361);
            this.panel14.TabIndex = 9;
            // 
            // cbAllow
            // 
            this.cbAllow.AutoSize = true;
            this.cbAllow.Enabled = false;
            this.cbAllow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllow.Location = new System.Drawing.Point(35, 25);
            this.cbAllow.Name = "cbAllow";
            this.cbAllow.Size = new System.Drawing.Size(275, 20);
            this.cbAllow.TabIndex = 18;
            this.cbAllow.Text = "Allow personalized levels for the channels";
            this.cbAllow.UseVisualStyleBackColor = true;
            this.cbAllow.Click += new System.EventHandler(this.cbAllow_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(199, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 3;
            // 
            // pnlSlidersConstant
            // 
            this.pnlSlidersConstant.Controls.Add(this.ucSliderConstant6);
            this.pnlSlidersConstant.Controls.Add(this.ucSliderConstant5);
            this.pnlSlidersConstant.Controls.Add(this.ucSliderConstant4);
            this.pnlSlidersConstant.Controls.Add(this.ucSliderConstant3);
            this.pnlSlidersConstant.Controls.Add(this.ucSliderConstant2);
            this.pnlSlidersConstant.Controls.Add(this.ucSliderConstant1);
            this.pnlSlidersConstant.Enabled = false;
            this.pnlSlidersConstant.Location = new System.Drawing.Point(35, 49);
            this.pnlSlidersConstant.Name = "pnlSlidersConstant";
            this.pnlSlidersConstant.Size = new System.Drawing.Size(473, 302);
            this.pnlSlidersConstant.TabIndex = 19;
            // 
            // tabPageAdvanced
            // 
            this.tabPageAdvanced.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageAdvanced.Controls.Add(this.panel);
            this.tabPageAdvanced.Location = new System.Drawing.Point(4, 31);
            this.tabPageAdvanced.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageAdvanced.Name = "tabPageAdvanced";
            this.tabPageAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvanced.Size = new System.Drawing.Size(799, 440);
            this.tabPageAdvanced.TabIndex = 5;
            this.tabPageAdvanced.Text = "Calibration (Advanced)";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Controls.Add(this.pnlDisplay);
            this.panel.Controls.Add(this.panel11);
            this.panel.Controls.Add(this.panel13);
            this.panel.Controls.Add(this.pnlNewAdvanced);
            this.panel.Location = new System.Drawing.Point(0, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(797, 439);
            this.panel.TabIndex = 11;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDisplay.Controls.Add(this.rbPortrait);
            this.pnlDisplay.Controls.Add(this.label6);
            this.pnlDisplay.Controls.Add(this.rbLandscape);
            this.pnlDisplay.Location = new System.Drawing.Point(215, 5);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(380, 61);
            this.pnlDisplay.TabIndex = 16;
            // 
            // rbPortrait
            // 
            this.rbPortrait.AutoSize = true;
            this.rbPortrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPortrait.Location = new System.Drawing.Point(275, 20);
            this.rbPortrait.Name = "rbPortrait";
            this.rbPortrait.Size = new System.Drawing.Size(68, 20);
            this.rbPortrait.TabIndex = 15;
            this.rbPortrait.TabStop = true;
            this.rbPortrait.Text = "Portrait";
            this.rbPortrait.UseVisualStyleBackColor = true;
            this.rbPortrait.CheckedChanged += new System.EventHandler(this.rbPortrait_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type of display:";
            // 
            // rbLandscape
            // 
            this.rbLandscape.AutoSize = true;
            this.rbLandscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLandscape.Location = new System.Drawing.Point(175, 20);
            this.rbLandscape.Name = "rbLandscape";
            this.rbLandscape.Size = new System.Drawing.Size(94, 20);
            this.rbLandscape.TabIndex = 14;
            this.rbLandscape.TabStop = true;
            this.rbLandscape.Text = "Landscape";
            this.rbLandscape.UseVisualStyleBackColor = true;
            this.rbLandscape.CheckedChanged += new System.EventHandler(this.rbLandscape_CheckedChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.btnIP4);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.pbConnection4);
            this.panel11.Controls.Add(this.lblConnected4);
            this.panel11.Location = new System.Drawing.Point(5, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(204, 61);
            this.panel11.TabIndex = 10;
            // 
            // btnIP4
            // 
            this.btnIP4.BackgroundImage = global::Simulatore_luce_solare.Properties.Resources._87756_gear_512x512;
            this.btnIP4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIP4.Location = new System.Drawing.Point(168, 18);
            this.btnIP4.Name = "btnIP4";
            this.btnIP4.Size = new System.Drawing.Size(25, 25);
            this.btnIP4.TabIndex = 12;
            this.btnIP4.UseMnemonic = false;
            this.btnIP4.UseVisualStyleBackColor = true;
            this.btnIP4.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "State:";
            // 
            // pbConnection4
            // 
            this.pbConnection4.BackColor = System.Drawing.SystemColors.Control;
            this.pbConnection4.Image = ((System.Drawing.Image)(resources.GetObject("pbConnection4.Image")));
            this.pbConnection4.Location = new System.Drawing.Point(57, 22);
            this.pbConnection4.Name = "pbConnection4";
            this.pbConnection4.Size = new System.Drawing.Size(11, 17);
            this.pbConnection4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConnection4.TabIndex = 9;
            this.pbConnection4.TabStop = false;
            this.pbConnection4.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbConnection4.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // lblConnected4
            // 
            this.lblConnected4.AutoSize = true;
            this.lblConnected4.BackColor = System.Drawing.SystemColors.Control;
            this.lblConnected4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected4.ForeColor = System.Drawing.Color.Red;
            this.lblConnected4.Location = new System.Drawing.Point(70, 22);
            this.lblConnected4.Name = "lblConnected4";
            this.lblConnected4.Size = new System.Drawing.Size(95, 16);
            this.lblConnected4.TabIndex = 8;
            this.lblConnected4.Text = "Not connected";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.Control;
            this.panel13.Controls.Add(this.pbDot1);
            this.panel13.Controls.Add(this.cbChannels);
            this.panel13.Controls.Add(this.pbDot4);
            this.panel13.Controls.Add(this.btnConfirmDot);
            this.panel13.Controls.Add(this.pbDot2);
            this.panel13.Controls.Add(this.nudPower);
            this.panel13.Controls.Add(this.pbDot3);
            this.panel13.Controls.Add(this.pbDot5);
            this.panel13.Controls.Add(this.pbDot6);
            this.panel13.Controls.Add(this.pbDisplay);
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(413, 72);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(380, 361);
            this.panel13.TabIndex = 7;
            // 
            // pbDot1
            // 
            this.pbDot1.BackColor = System.Drawing.SystemColors.Window;
            this.pbDot1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbDot1.Enabled = false;
            this.pbDot1.Image = ((System.Drawing.Image)(resources.GetObject("pbDot1.Image")));
            this.pbDot1.Location = new System.Drawing.Point(142, 88);
            this.pbDot1.Name = "pbDot1";
            this.pbDot1.Size = new System.Drawing.Size(13, 13);
            this.pbDot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDot1.TabIndex = 16;
            this.pbDot1.TabStop = false;
            this.pbDot1.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbDot1.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.pbDot1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDot_MouseClick);
            this.pbDot1.MouseEnter += new System.EventHandler(this.pbDot_MouseEnter);
            this.pbDot1.MouseLeave += new System.EventHandler(this.pbDot_MouseLeave);
            // 
            // cbChannels
            // 
            this.cbChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChannels.FormattingEnabled = true;
            this.cbChannels.Location = new System.Drawing.Point(103, 21);
            this.cbChannels.Name = "cbChannels";
            this.cbChannels.Size = new System.Drawing.Size(158, 24);
            this.cbChannels.TabIndex = 17;
            this.cbChannels.SelectedIndexChanged += new System.EventHandler(this.cbChannels_SelectedIndexChanged);
            this.cbChannels.Leave += new System.EventHandler(this.cbChannels_Leave);
            // 
            // pbDot4
            // 
            this.pbDot4.BackColor = System.Drawing.SystemColors.Window;
            this.pbDot4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbDot4.Enabled = false;
            this.pbDot4.Image = ((System.Drawing.Image)(resources.GetObject("pbDot4.Image")));
            this.pbDot4.Location = new System.Drawing.Point(207, 149);
            this.pbDot4.Name = "pbDot4";
            this.pbDot4.Size = new System.Drawing.Size(13, 13);
            this.pbDot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDot4.TabIndex = 16;
            this.pbDot4.TabStop = false;
            this.pbDot4.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbDot4.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.pbDot4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDot_MouseClick);
            this.pbDot4.MouseEnter += new System.EventHandler(this.pbDot_MouseEnter);
            this.pbDot4.MouseLeave += new System.EventHandler(this.pbDot_MouseLeave);
            // 
            // btnConfirmDot
            // 
            this.btnConfirmDot.Enabled = false;
            this.btnConfirmDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDot.Location = new System.Drawing.Point(182, 303);
            this.btnConfirmDot.Name = "btnConfirmDot";
            this.btnConfirmDot.Size = new System.Drawing.Size(67, 23);
            this.btnConfirmDot.TabIndex = 6;
            this.btnConfirmDot.Text = "Apply";
            this.btnConfirmDot.UseVisualStyleBackColor = true;
            this.btnConfirmDot.Visible = false;
            this.btnConfirmDot.Click += new System.EventHandler(this.btnConfirmDot_Click);
            // 
            // pbDot2
            // 
            this.pbDot2.BackColor = System.Drawing.SystemColors.Window;
            this.pbDot2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbDot2.Enabled = false;
            this.pbDot2.Image = ((System.Drawing.Image)(resources.GetObject("pbDot2.Image")));
            this.pbDot2.Location = new System.Drawing.Point(207, 88);
            this.pbDot2.Name = "pbDot2";
            this.pbDot2.Size = new System.Drawing.Size(13, 13);
            this.pbDot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDot2.TabIndex = 16;
            this.pbDot2.TabStop = false;
            this.pbDot2.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbDot2.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.pbDot2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDot_MouseClick);
            this.pbDot2.MouseEnter += new System.EventHandler(this.pbDot_MouseEnter);
            this.pbDot2.MouseLeave += new System.EventHandler(this.pbDot_MouseLeave);
            // 
            // nudPower
            // 
            this.nudPower.Enabled = false;
            this.nudPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPower.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPower.Location = new System.Drawing.Point(116, 304);
            this.nudPower.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudPower.Name = "nudPower";
            this.nudPower.Size = new System.Drawing.Size(56, 22);
            this.nudPower.TabIndex = 16;
            this.nudPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPower.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPower.Visible = false;
            this.nudPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPower_KeyPress);
            // 
            // pbDot3
            // 
            this.pbDot3.BackColor = System.Drawing.SystemColors.Window;
            this.pbDot3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbDot3.Enabled = false;
            this.pbDot3.Image = ((System.Drawing.Image)(resources.GetObject("pbDot3.Image")));
            this.pbDot3.Location = new System.Drawing.Point(142, 149);
            this.pbDot3.Name = "pbDot3";
            this.pbDot3.Size = new System.Drawing.Size(13, 13);
            this.pbDot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDot3.TabIndex = 16;
            this.pbDot3.TabStop = false;
            this.pbDot3.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbDot3.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.pbDot3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDot_MouseClick);
            this.pbDot3.MouseEnter += new System.EventHandler(this.pbDot_MouseEnter);
            this.pbDot3.MouseLeave += new System.EventHandler(this.pbDot_MouseLeave);
            // 
            // pbDot5
            // 
            this.pbDot5.BackColor = System.Drawing.SystemColors.Window;
            this.pbDot5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbDot5.Enabled = false;
            this.pbDot5.Image = ((System.Drawing.Image)(resources.GetObject("pbDot5.Image")));
            this.pbDot5.Location = new System.Drawing.Point(142, 212);
            this.pbDot5.Name = "pbDot5";
            this.pbDot5.Size = new System.Drawing.Size(13, 13);
            this.pbDot5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDot5.TabIndex = 16;
            this.pbDot5.TabStop = false;
            this.pbDot5.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbDot5.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.pbDot5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDot_MouseClick);
            this.pbDot5.MouseEnter += new System.EventHandler(this.pbDot_MouseEnter);
            this.pbDot5.MouseLeave += new System.EventHandler(this.pbDot_MouseLeave);
            // 
            // pbDot6
            // 
            this.pbDot6.BackColor = System.Drawing.SystemColors.Window;
            this.pbDot6.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbDot6.Enabled = false;
            this.pbDot6.Image = ((System.Drawing.Image)(resources.GetObject("pbDot6.Image")));
            this.pbDot6.Location = new System.Drawing.Point(207, 212);
            this.pbDot6.Name = "pbDot6";
            this.pbDot6.Size = new System.Drawing.Size(13, 13);
            this.pbDot6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDot6.TabIndex = 16;
            this.pbDot6.TabStop = false;
            this.pbDot6.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbDot6.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.pbDot6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDot_MouseClick);
            this.pbDot6.MouseEnter += new System.EventHandler(this.pbDot_MouseEnter);
            this.pbDot6.MouseLeave += new System.EventHandler(this.pbDot_MouseLeave);
            // 
            // pbDisplay
            // 
            this.pbDisplay.Enabled = false;
            this.pbDisplay.Image = ((System.Drawing.Image)(resources.GetObject("pbDisplay.Image")));
            this.pbDisplay.Location = new System.Drawing.Point(25, 0);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(314, 361);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisplay.TabIndex = 15;
            this.pbDisplay.TabStop = false;
            this.pbDisplay.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.pbDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // pnlNewAdvanced
            // 
            this.pnlNewAdvanced.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNewAdvanced.Controls.Add(this.panel6);
            this.pnlNewAdvanced.Controls.Add(this.lblCurrChannel);
            this.pnlNewAdvanced.Controls.Add(this.lblAdvanced);
            this.pnlNewAdvanced.Controls.Add(this.btnNextAdvanced);
            this.pnlNewAdvanced.Controls.Add(this.btnNewAdvanced);
            this.pnlNewAdvanced.Controls.Add(this.btnCancelNewAdvanced);
            this.pnlNewAdvanced.Controls.Add(this.btnSaveNewAdvanced);
            this.pnlNewAdvanced.Controls.Add(this.btnPreviousAdvanced);
            this.pnlNewAdvanced.Location = new System.Drawing.Point(5, 72);
            this.pnlNewAdvanced.Name = "pnlNewAdvanced";
            this.pnlNewAdvanced.Size = new System.Drawing.Size(402, 361);
            this.pnlNewAdvanced.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pbNewAdvanced);
            this.panel6.Location = new System.Drawing.Point(36, 202);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 34);
            this.panel6.TabIndex = 16;
            this.panel6.EnabledChanged += new System.EventHandler(this.pb_EnabledChanged);
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // pbNewAdvanced
            // 
            this.pbNewAdvanced.Location = new System.Drawing.Point(3, 8);
            this.pbNewAdvanced.Maximum = 60;
            this.pbNewAdvanced.Name = "pbNewAdvanced";
            this.pbNewAdvanced.Size = new System.Drawing.Size(264, 23);
            this.pbNewAdvanced.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbNewAdvanced.TabIndex = 14;
            // 
            // lblCurrChannel
            // 
            this.lblCurrChannel.AutoSize = true;
            this.lblCurrChannel.Location = new System.Drawing.Point(136, 176);
            this.lblCurrChannel.Name = "lblCurrChannel";
            this.lblCurrChannel.Size = new System.Drawing.Size(0, 16);
            this.lblCurrChannel.TabIndex = 15;
            // 
            // lblAdvanced
            // 
            this.lblAdvanced.AutoSize = true;
            this.lblAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanced.Location = new System.Drawing.Point(56, 120);
            this.lblAdvanced.Name = "lblAdvanced";
            this.lblAdvanced.Size = new System.Drawing.Size(184, 30);
            this.lblAdvanced.TabIndex = 12;
            this.lblAdvanced.Text = "Select \'New calibration\' to start a\r\nnew regulation of the channels\r\n";
            // 
            // btnNextAdvanced
            // 
            this.btnNextAdvanced.Enabled = false;
            this.btnNextAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAdvanced.Location = new System.Drawing.Point(173, 243);
            this.btnNextAdvanced.Name = "btnNextAdvanced";
            this.btnNextAdvanced.Size = new System.Drawing.Size(122, 23);
            this.btnNextAdvanced.TabIndex = 6;
            this.btnNextAdvanced.Text = "Next step >";
            this.btnNextAdvanced.UseVisualStyleBackColor = true;
            this.btnNextAdvanced.Click += new System.EventHandler(this.btnNextAdvanced_Click);
            // 
            // btnNewAdvanced
            // 
            this.btnNewAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAdvanced.Location = new System.Drawing.Point(23, 40);
            this.btnNewAdvanced.Name = "btnNewAdvanced";
            this.btnNewAdvanced.Size = new System.Drawing.Size(149, 27);
            this.btnNewAdvanced.TabIndex = 11;
            this.btnNewAdvanced.Text = "New calibration";
            this.btnNewAdvanced.UseVisualStyleBackColor = true;
            this.btnNewAdvanced.Click += new System.EventHandler(this.btnNewAdvanced_Click);
            // 
            // btnCancelNewAdvanced
            // 
            this.btnCancelNewAdvanced.Enabled = false;
            this.btnCancelNewAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNewAdvanced.Location = new System.Drawing.Point(217, 306);
            this.btnCancelNewAdvanced.Name = "btnCancelNewAdvanced";
            this.btnCancelNewAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnCancelNewAdvanced.TabIndex = 6;
            this.btnCancelNewAdvanced.Text = "Cancel";
            this.btnCancelNewAdvanced.UseVisualStyleBackColor = true;
            this.btnCancelNewAdvanced.Click += new System.EventHandler(this.btnCancelNewAdvanced_Click);
            // 
            // btnSaveNewAdvanced
            // 
            this.btnSaveNewAdvanced.Enabled = false;
            this.btnSaveNewAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewAdvanced.Location = new System.Drawing.Point(298, 306);
            this.btnSaveNewAdvanced.Name = "btnSaveNewAdvanced";
            this.btnSaveNewAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewAdvanced.TabIndex = 6;
            this.btnSaveNewAdvanced.Text = "Done";
            this.btnSaveNewAdvanced.UseVisualStyleBackColor = true;
            this.btnSaveNewAdvanced.Click += new System.EventHandler(this.btnSaveNewAdvanced_Click);
            // 
            // btnPreviousAdvanced
            // 
            this.btnPreviousAdvanced.Enabled = false;
            this.btnPreviousAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousAdvanced.Location = new System.Drawing.Point(45, 243);
            this.btnPreviousAdvanced.Name = "btnPreviousAdvanced";
            this.btnPreviousAdvanced.Size = new System.Drawing.Size(122, 23);
            this.btnPreviousAdvanced.TabIndex = 13;
            this.btnPreviousAdvanced.Text = "< Previous step";
            this.btnPreviousAdvanced.UseVisualStyleBackColor = true;
            this.btnPreviousAdvanced.Click += new System.EventHandler(this.btnPreviousAdvanced_Click);
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label26.Location = new System.Drawing.Point(12, 481);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(786, 26);
            this.label26.TabIndex = 4;
            this.label26.Text = "The \"Sunlight simulator\" project was developed by Federico Zarantonello on behalf" +
    " of Global Display Solutions.\r\n";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucSliderConstant6
            // 
            this.ucSliderConstant6.Location = new System.Drawing.Point(372, 5);
            this.ucSliderConstant6.Name = "ucSliderConstant6";
            this.ucSliderConstant6.Size = new System.Drawing.Size(73, 292);
            this.ucSliderConstant6.TabIndex = 19;
            this.ucSliderConstant6.Value = 255;
            // 
            // ucSliderConstant5
            // 
            this.ucSliderConstant5.Location = new System.Drawing.Point(302, 5);
            this.ucSliderConstant5.Name = "ucSliderConstant5";
            this.ucSliderConstant5.Size = new System.Drawing.Size(73, 292);
            this.ucSliderConstant5.TabIndex = 18;
            this.ucSliderConstant5.Value = 255;
            // 
            // ucSliderConstant4
            // 
            this.ucSliderConstant4.Location = new System.Drawing.Point(233, 5);
            this.ucSliderConstant4.Name = "ucSliderConstant4";
            this.ucSliderConstant4.Size = new System.Drawing.Size(73, 292);
            this.ucSliderConstant4.TabIndex = 17;
            this.ucSliderConstant4.Value = 255;
            // 
            // ucSliderConstant3
            // 
            this.ucSliderConstant3.Location = new System.Drawing.Point(163, 5);
            this.ucSliderConstant3.Name = "ucSliderConstant3";
            this.ucSliderConstant3.Size = new System.Drawing.Size(73, 292);
            this.ucSliderConstant3.TabIndex = 16;
            this.ucSliderConstant3.Value = 255;
            // 
            // ucSliderConstant2
            // 
            this.ucSliderConstant2.Location = new System.Drawing.Point(93, 5);
            this.ucSliderConstant2.Name = "ucSliderConstant2";
            this.ucSliderConstant2.Size = new System.Drawing.Size(73, 292);
            this.ucSliderConstant2.TabIndex = 15;
            this.ucSliderConstant2.Value = 255;
            // 
            // ucSliderConstant1
            // 
            this.ucSliderConstant1.Location = new System.Drawing.Point(27, 5);
            this.ucSliderConstant1.Name = "ucSliderConstant1";
            this.ucSliderConstant1.Size = new System.Drawing.Size(73, 292);
            this.ucSliderConstant1.TabIndex = 14;
            this.ucSliderConstant1.Value = 255;
            // 
            // ucSlider1
            // 
            this.ucSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSlider1.Location = new System.Drawing.Point(24, 39);
            this.ucSlider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSlider1.Name = "ucSlider1";
            this.ucSlider1.Size = new System.Drawing.Size(88, 357);
            this.ucSlider1.TabIndex = 8;
            this.ucSlider1.Value = 255;
            // 
            // ucSlider2
            // 
            this.ucSlider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSlider2.Location = new System.Drawing.Point(100, 39);
            this.ucSlider2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSlider2.Name = "ucSlider2";
            this.ucSlider2.Size = new System.Drawing.Size(90, 357);
            this.ucSlider2.TabIndex = 9;
            this.ucSlider2.Value = 255;
            // 
            // ucSlider3
            // 
            this.ucSlider3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSlider3.Location = new System.Drawing.Point(178, 39);
            this.ucSlider3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSlider3.Name = "ucSlider3";
            this.ucSlider3.Size = new System.Drawing.Size(94, 346);
            this.ucSlider3.TabIndex = 10;
            this.ucSlider3.Value = 255;
            // 
            // ucSlider4
            // 
            this.ucSlider4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSlider4.Location = new System.Drawing.Point(260, 39);
            this.ucSlider4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSlider4.Name = "ucSlider4";
            this.ucSlider4.Size = new System.Drawing.Size(91, 346);
            this.ucSlider4.TabIndex = 11;
            this.ucSlider4.Value = 255;
            // 
            // ucSlider5
            // 
            this.ucSlider5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSlider5.Location = new System.Drawing.Point(339, 39);
            this.ucSlider5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSlider5.Name = "ucSlider5";
            this.ucSlider5.Size = new System.Drawing.Size(95, 346);
            this.ucSlider5.TabIndex = 12;
            this.ucSlider5.Value = 255;
            // 
            // ucSlider6
            // 
            this.ucSlider6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSlider6.Location = new System.Drawing.Point(422, 39);
            this.ucSlider6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSlider6.Name = "ucSlider6";
            this.ucSlider6.Size = new System.Drawing.Size(101, 346);
            this.ucSlider6.TabIndex = 13;
            this.ucSlider6.Value = 255;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 503);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Sunlight simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabPageStandard.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.pnlNewStandard.ResumeLayout(false);
            this.pnlNewStandard.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection3)).EndInit();
            this.pnlSliders.ResumeLayout(false);
            this.pnlSliders.PerformLayout();
            this.tabPageSimulation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMode2.ResumeLayout(false);
            this.pnlMode2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageConstant.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlPower.ResumeLayout(false);
            this.pnlPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPowerConstant)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.pnlDuration.ResumeLayout(false);
            this.pnlDuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursConstant)).EndInit();
            this.pnlMode1.ResumeLayout(false);
            this.pnlMode1.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection1)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.pnlSlidersConstant.ResumeLayout(false);
            this.tabPageAdvanced.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection4)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDot6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.pnlNewAdvanced.ResumeLayout(false);
            this.pnlNewAdvanced.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdDay;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.Timer timerSimulation;
        private System.Windows.Forms.Timer timerHeating;
        private System.Windows.Forms.Timer timerCooling;
        private System.Windows.Forms.TabPage tabPageStandard;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel pnlNewStandard;
        private System.Windows.Forms.Button btnNewStandard;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbConnection3;
        private System.Windows.Forms.Label lblConnected3;
        private System.Windows.Forms.Panel pnlSliders;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPageSimulation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lblChart;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResetSimulation;
        private System.Windows.Forms.PictureBox pbConnection2;
        private System.Windows.Forms.Button btnLoadSimulation;
        private System.Windows.Forms.Label lblConnected2;
        private System.Windows.Forms.Button btnChooseChart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblSlope;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAdvanced;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton rbLandscape;
        private System.Windows.Forms.RadioButton rbPortrait;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbConnection4;
        private System.Windows.Forms.Label lblConnected4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cbChannels;
        private System.Windows.Forms.PictureBox pbDot4;
        private System.Windows.Forms.Button btnConfirmDot;
        private System.Windows.Forms.PictureBox pbDot5;
        private System.Windows.Forms.PictureBox pbDot6;
        private System.Windows.Forms.PictureBox pbDot3;
        private System.Windows.Forms.PictureBox pbDot2;
        private System.Windows.Forms.PictureBox pbDot1;
        private System.Windows.Forms.NumericUpDown nudPower;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.Panel pnlNewAdvanced;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ProgressBar pbNewAdvanced;
        private System.Windows.Forms.Label lblCurrChannel;
        private System.Windows.Forms.Label lblAdvanced;
        private System.Windows.Forms.Button btnNextAdvanced;
        private System.Windows.Forms.Button btnNewAdvanced;
        private System.Windows.Forms.Button btnCancelNewAdvanced;
        private System.Windows.Forms.Button btnSaveNewAdvanced;
        private System.Windows.Forms.Button btnPreviousAdvanced;
        private System.Windows.Forms.RadioButton rbAdvanced2;
        private System.Windows.Forms.RadioButton rbStandard2;
        private System.Windows.Forms.Panel pnlMode2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMode2;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageConstant;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblConnected1;
        private System.Windows.Forms.PictureBox pbConnection1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlDuration;
        private System.Windows.Forms.NumericUpDown nudMinutesConstant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudHoursConstant;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnResetConstant;
        private System.Windows.Forms.Button btnLoadConstant;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.NumericUpDown nudPowerConstant;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbAllow;
        private System.Windows.Forms.Panel pnlPower;
        private System.Windows.Forms.Panel pnlSlidersConstant;
        private ucSlider ucSlider6;
        private ucSlider ucSlider5;
        private ucSlider ucSlider4;
        private ucSlider ucSlider3;
        private ucSlider ucSlider2;
        private ucSlider ucSlider1;
        private ucSlider ucSliderConstant6;
        private ucSlider ucSliderConstant5;
        private ucSlider ucSliderConstant4;
        private ucSlider ucSliderConstant3;
        private ucSlider ucSliderConstant2;
        private ucSlider ucSliderConstant1;
        private System.Windows.Forms.Label lblAdvise;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnIP1;
        private System.Windows.Forms.Button btnIP2;
        private System.Windows.Forms.Button btnIP3;
        private System.Windows.Forms.Button btnIP4;
        private System.Windows.Forms.Panel pnlMode1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblMode1;
        private System.Windows.Forms.RadioButton rbAdvanced1;
        private System.Windows.Forms.RadioButton rbStandard1;
        private System.Windows.Forms.Label label26;
    }
}

