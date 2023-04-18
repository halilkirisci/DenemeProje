using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Mathh
    {
        public int birinci { get; set; }
        public int ikinci { get; set; }

        public Mathh(int birinci, int ikinci)
        {
            this.birinci = birinci;
            this.ikinci = ikinci;
        }

        public Mathh()
        {
            this.birinci = 1;
            this.ikinci = 2;
        }

        public int Toplama() { return birinci + ikinci; }
        public int Cikarma() { return ikinci - ikinci; }
        public int Carpma() { return ikinci * ikinci; }

    }
}
