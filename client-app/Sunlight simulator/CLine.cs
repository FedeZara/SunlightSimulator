using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulatore_luce_solare
{
    class CLine
    {
        public DataPoint Start { get; set; }
        public DataPoint End { get; set; }
        public double Slope { get; set; }
        public double Intercept { get; set; }

        public CLine(DataPoint Start, DataPoint End)
        {
            this.Start = Start;
            this.End = End;
            this.Slope = (End.YValues[0] - Start.YValues[0])/ (End.XValue - Start.XValue);
            this.Intercept = Start.YValues[0] - this.Slope * Start.XValue;
        }
    }
}
