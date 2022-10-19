using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class UnderwaterLevel:ILevel
    {
        public List<CreateNPC> listNPC { get; set; }
        public List<CreateDecorations> decorations { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public UnderwaterLevel(List<CreateNPC> _listNPC, List<CreateDecorations> decorations, string _Type, int _Size)
        {
            this.listNPC = _listNPC;
            this.Type = _Type;
            this.Size = _Size;
            this.decorations = decorations;
        }
        public string[,] CreateLevel()
        {
            string[,] level = new string[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {

                    level[i, j] = "~";
                    for (int k = 0; k < decorations.Count; k++)
                    {
                        if (i == decorations[k].x && j == decorations[k].y && decorations[k].Type != "Tree")
                        {
                            level[i, j] = "^";
                        }

                    }

                    for (int k = 0; k < listNPC.Count; k++)
                    {
                        if (i == listNPC[k]._x && j == listNPC[k]._y)
                        {
                            level[i, j] = "*";

                        }
                    }

                }
            }
            return level;
        }
    }
}
