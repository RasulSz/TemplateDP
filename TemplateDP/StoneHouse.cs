using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDP
{
    public class StoneHouse : BuildHouse
    {
        public override void AddStair()
        {
            Console.WriteLine("Stone Stairs Successfully Built");
        }
        public override void AddWalls()
        {
            Console.WriteLine("Stone Walls Successfully Built");
        }
    }
}
