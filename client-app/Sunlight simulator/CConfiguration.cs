using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulatore_luce_solare
{
    class CStandard
    {
        private int[] _Values;
        public int Power;

        public int[] Values
        {
            get
            {
                return _Values;
            }
            set
            {
                if (value.GetLength(0) != 6)
                    throw new ArgumentException();
                _Values = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    if (_Values[i] > 255 || _Values[i] < 0)
                        throw new ArgumentException();
                    _Values[i] = value[i];
                }
            }
        }

        public CStandard(int Power, int[] Values)
        {
            this.Power = Power;
            this.Values = Values;
        }

        public CStandard(int Power, int value1, int value2, int value3, int value4, int value5, int value6)
        {
            this.Power = Power;
            int[] tempValues = new int[6];
            tempValues[0] = value1;
            tempValues[1] = value2;
            tempValues[2] = value3;
            tempValues[3] = value4;
            tempValues[4] = value5;
            tempValues[5] = value6;
            Values = tempValues;
        }

        public override string ToString()
        {
            return "" + Power;
        }
    }
}
