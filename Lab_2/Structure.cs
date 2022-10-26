using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Structure:CompositeComponent
    {
        private List<CompositeComponent> components =new List<CompositeComponent>();
        public Structure(string Name) : base(Name)
        {

        }

        public override ICompositeComponent Add(ICompositeComponent compositeComponent)
        {
            components.Add(compositeComponent as CompositeComponent);
            return this;
        }
        public override string ToString(int level)
        {
            string Result = $"{ new String('.', 3 * level)}{ this}\n";
            foreach(CompositeComponent component in components)
            {
                Result+=component.ToString(level+1);
            }
            return Result;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
