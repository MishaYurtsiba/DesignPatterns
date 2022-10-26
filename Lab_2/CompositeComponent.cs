using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class CompositeComponent:ICompositeComponent
    {
        public string Name;

        public CompositeComponent(string Name)
        {
            this.Name = Name;
        }

        public virtual ICompositeComponent Add(ICompositeComponent compositeComponent)
        {
            throw new Exception();
        }

        public virtual ICompositeComponent Remove(ICompositeComponent compositeComponent)
        {
            throw new Exception();
        }
        public virtual string ToString(int level)
        {
            return $"{ new String('.', 3 * level)}{ this}\n";
        }
    }
}
