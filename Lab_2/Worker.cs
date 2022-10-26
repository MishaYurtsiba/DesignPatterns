using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Worker : CompositeComponent
    {
        public string position;

        public Worker(string Name,string position) : base(Name)
        {
            this.position = position;
        }
        public override string ToString()
        {
            return $"{Name}({position})";
        }
    }
}
