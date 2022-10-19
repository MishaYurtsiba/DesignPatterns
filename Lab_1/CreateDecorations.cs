using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class CreateDecorations
    {
        public string Type;
        public int x;
        public int y;
        
        public CreateDecorations(string Type,int x, int y)
        {
            this.Type = Type;
            this.x = x;
            this.y = y;
        }
    }
}
