using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Para
    {
        private readonly string nachpar;
        public string Nachpar { get => nachpar; }

        private readonly string okonchpar;
        public string Okonchpar { get => okonchpar; }
        private readonly string nachper;
        public string Nachper { get => nachper; }
        private readonly string okonchper;
        public string Okonchper { get => okonchper; }
        private readonly Smena smena;
        public Smena Smena { get => smena; }

        public Para(string nachpar, string okonchpar, string nachper, string okonchper, Smena smena)
        {
            this.nachpar = nachpar;
            this.okonchpar = okonchpar;
            this.nachper = nachper;
            this.okonchper = okonchper;
            this.smena = smena;
        }
    }
}
