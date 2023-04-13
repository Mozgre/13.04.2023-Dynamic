using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Podrazdelenie
    {
        private readonly string nazvanie;
        public string Nazvanie { get => nazvanie; }

        private readonly Sotrydnik rykovoditel;
        public Sotrydnik Rykovoditel { get => rykovoditel; }

        private readonly Organizacia organizacia;
        public Organizacia Organizacia { get => organizacia; }

        public Podrazdelenie(string nazvanie, Sotrydnik rykovoditel, Organizacia organizacia)
        {
            this.nazvanie = nazvanie;
            this.rykovoditel = rykovoditel;
            this.organizacia = organizacia;
        }
    }
}