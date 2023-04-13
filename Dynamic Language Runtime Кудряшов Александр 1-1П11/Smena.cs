using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Smena
    {
        private readonly string nazvanie;
        public string Nazvanie { get => nazvanie; }
        public Smena(string nazvanie)
        {
            this.nazvanie = nazvanie;
        }
    }
}
