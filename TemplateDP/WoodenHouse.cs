using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDP
{
    public class WoodenHouse : BuildHouse
    {
        public override void AddWalls()
        {
            Console.WriteLine("Wooden Walls Successfully Built");
        }
        public override void AddStair()
        {
            Console.WriteLine("Wooden Stairs Successfully Built");
        }
    }
}
