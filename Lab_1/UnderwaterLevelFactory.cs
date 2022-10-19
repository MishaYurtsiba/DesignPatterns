using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class UnderwaterLevelFactory : LevelFactory
    {
        private readonly List<CreateNPC> listNPC;
        private readonly List<CreateDecorations> decorations;
        private readonly string Type;
        private readonly int Size;

        public UnderwaterLevelFactory(List<CreateNPC> _listNPC, List<CreateDecorations> decorations, string _Type, int _Size)
        {
            this.listNPC = _listNPC;
            this.Type = _Type;
            this.Size = _Size;
            this.decorations = decorations;
        }
        public override ILevel GetLevel()
        {
            UnderwaterLevel level = new UnderwaterLevel(listNPC,decorations, Type, Size)
            {

            };
            return level;
        }
    }
}
