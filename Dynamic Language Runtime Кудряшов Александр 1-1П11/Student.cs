using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Language_Runtime_Кудряшов_Александр_1_1П11
{
    public class Student
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string familia;
        public string Familia { get => familia; }
        private readonly string otchestvo;
        public string Otchestvo { get => otchestvo; }

        private readonly Gryppa gryppa;
        public Gryppa Gryppa { get => gryppa; }

        public DateTime Data { get => data; }
        private readonly DateTime data;

        public Student(string name, string familia, string otchestvo, Gryppa gryppa, DateTime data)
        {
            this.name = name;
            this.familia = familia;
            this.otchestvo = otchestvo;
            this.gryppa = gryppa;
            this.data = data;
        }
    }
}
