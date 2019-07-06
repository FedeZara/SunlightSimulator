using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulatore_luce_solare
{
    public partial class ucSlider : UserControl
    {
        private int _Value;

        public int Value
        {
            get { return _Value; }
            set
            {
                if (value > 255 || value < 0)
                    throw new ArgumentException();
                else
                {
                    _Value = value;
                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            nudSlider.ValueChanged -= nudSlider_ValueChanged;
                            nudSlider.Value = value;
                            nudSlider.ValueChanged += nudSlider_ValueChanged;
                            tbSlider.Value = (int)value;
                        });
                    }
                    else
                    {
                        nudSlider.ValueChanged -= nudSlider_ValueChanged;
                        nudSlider.Value = value;
                        nudSlider.ValueChanged += nudSlider_ValueChanged;
                        tbSlider.Value = (int)value;
                    }
                }
            }
        }
        public ucSlider()
        {
            InitializeComponent();
            Value = 255;
        }

        private void tbSlider_Scroll(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                nudSlider.ValueChanged -= nudSlider_ValueChanged;
                nudSlider.Value = tbSlider.Value;
                nudSlider.ValueChanged += nudSlider_ValueChanged;
                Value = tbSlider.Value;
                (this.FindForm() as Main).SlidersModified();
            });
        }

        private void nudSlider_ValueChanged(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                Value = tbSlider.Value = (int)nudSlider.Value;
                (this.FindForm() as Main).SlidersModified();
            });
        }
    }
}
