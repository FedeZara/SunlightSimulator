using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulatore_luce_solare
{
    class CChannel
    {
        public int[,] Powers { get; set; }
        public int[] Channels { get; set; }
        public CChannel(int[,] Powers, int[] Channels)
        {
            this.Powers = Powers;
            this.Channels = Channels;
        }
        public CChannel(int[] Channels)
        {
            this.Powers = new int[2,3];
            this.Channels = Channels;
        }

        public void setPower(int x, int y, int value)
        {
            Powers[x, y] = value;
        }

        public override string ToString()
        {
            string s = "Canale ";
            foreach (int c in Channels)
                s += (c + 1) + " - ";
            s = s.Substring(0, s.Length - 3);
            return s;
        }
    }
}
