using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class CreateNPC
    {
        public string _name;
        public int _x;
        public int _y;
        public int _halsePoint;

        public CreateNPC(string name, int x, int y, int halsePoint)
        {
            _name = name;
            _x = x;
            _y = y;
            _halsePoint = halsePoint;
        }
    }
}
