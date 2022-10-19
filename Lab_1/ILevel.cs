using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal interface ILevel
    {
        List<CreateNPC> listNPC { get; set; }
        List<CreateDecorations> decorations { get; set; }
        string Type { get; set; }
        int Size { get; set; }
        string[,] CreateLevel();
        

        

    }
}
