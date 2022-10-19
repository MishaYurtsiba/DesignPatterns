using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            CreateNPC npc1 = new CreateNPC("npc1", 1, 1, 25);
            CreateNPC npc2 = new CreateNPC("npc2", 2, 2, 25);
            CreateNPC npc3 = new CreateNPC("npc3", 3, 3, 25);
            CreateNPC npc4 = new CreateNPC("npc3", 4, 4, 25);
            CreateNPC npc5 = new CreateNPC("npc3", 2, 4, 25);

            CreateDecorations d1 = new CreateDecorations("Tree", 5, 5);
            CreateDecorations d2 = new CreateDecorations("Tree", 7, 6);
            CreateDecorations d3 = new CreateDecorations("Stone", 5, 5);
            CreateDecorations d4 = new CreateDecorations("Stone", 4, 1);

            List<CreateNPC> npcList = new List<CreateNPC>();
            List<CreateDecorations>decorations = new List<CreateDecorations>();

            npcList.Add(npc1);
            npcList.Add(npc2);
            npcList.Add(npc3);
            npcList.Add(npc4);
            npcList.Add(npc5);

            decorations.Add(d1);
            decorations.Add(d2);
            decorations.Add(d3);
            decorations.Add(d4);

            int Size = 10;

            Console.WriteLine("Select a type of level");
            Console.WriteLine("> 1-TerrestrialLevel");
            Console.WriteLine("> 2-UnderwaterLevel");

            int levelType = Int32.Parse(Console.ReadLine());

            LevelFactory f=null;
            if (levelType == 1)
            {
                f = new TerrestrialLevelFactory(npcList,decorations, "Terrestrial", Size);
            }
            else if (levelType == 2)
            {
                f = new UnderwaterLevelFactory(npcList, decorations, "Underwater", Size);
            }
            

            ILevel level = f.GetLevel();

            string[,] lvl = level.CreateLevel();

            for(int i = 0 ; i < Size; i++)
            {
                for(int j = 0 ; j < Size; j++)
                {
                    Console.Write($"{lvl[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();



        }

        

    }

}
