using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulatore_luce_solare
{
    public class CDay
    {
        static private Dictionary<string, string> Months = new Dictionary<string, string>() {
            {"January", "Gennaio"},
            {"February", "Febbraio"},
            {"March", "Marzo"},
            {"April", "Aprile"},
            {"May", "Maggio"},
            {"June", "Giugno"},
            {"July", "Luglio"},
            {"August", "Agosto"},
            {"September", "Settembre"},
            {"October", "Ottobre"},
            {"November", "Novembre"},
            {"December", "Dicembre"},
        };


            
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Month { get; set; }
        public string Slope { get; set; }
        public List<DataPoint> Points { get; set; }

        public CDay(string FileCSV)
        {
            Points = new List<DataPoint>();
            using (var reader = new StreamReader(FileCSV))
            {
                string[] currLine = reader.ReadLine().Split();
                if(currLine.GetLength(0) == 1)
                {
                    currLine = currLine[0].Split(';');
                    while (true)
                    {
                        if (currLine[0] == "")
                            break;
                        string[] tString = currLine[0].Split(':');
                        double t = (double)Int32.Parse(tString[0]) + ((double)Int32.Parse(tString[1])) / 60.0;
                        Points.Add(new DataPoint(t, Int32.Parse(currLine[1])));
                        if (!reader.EndOfStream)
                            currLine = reader.ReadLine().Split(';');
                        else
                            break;
                    }
                    Latitude = "(non specificata)";
                    Longitude = "(non specificata)";
                    Month = "(non specificato)";
                    Slope = "(non specificata)";
                }
                else
                {
                    Latitude = currLine[3];
                    Longitude = reader.ReadLine().Split()[3];
                    reader.ReadLine();
                    reader.ReadLine();
                    Month = Months[reader.ReadLine().Split()[3]];
                    Slope = reader.ReadLine().Split()[5];
                    reader.ReadLine();
                    reader.ReadLine();
                    for (int i = 0; i < 24; i++)
                    {
                        Points.Add(new DataPoint(i, int.Parse(reader.ReadLine().Split()[2])));
                    }
                }
                
            }
        }
    }
}
