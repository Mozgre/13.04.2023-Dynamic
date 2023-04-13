using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Gryppa
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string shortname;
        public string Shortname { get => shortname; }

        private readonly byte chislennost;
        public byte Chislennost { get => chislennost; }

        private readonly short yearPostyp;
        public short YearPostyp { get => yearPostyp; }

        public Gryppa(string name, string shortname, byte chislennost, short yearPostyp)
        {
            this.name = name;
            this.shortname = shortname;
            this.chislennost = chislennost;
            this.yearPostyp = yearPostyp;
        }
    }
}
