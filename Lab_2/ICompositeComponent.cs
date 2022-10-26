using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal interface ICompositeComponent
    {
        ICompositeComponent Add(ICompositeComponent compositeComponent);
        ICompositeComponent Remove(ICompositeComponent compositeComponent);
    }
}
