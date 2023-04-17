using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDP
{
    public abstract class BuildHouse
    {
        public void Build()
        {
            AddWalls();
            AddWindows();
            AddStair();
        }
        public abstract void AddWalls();
        public void AddWindows()
        {
            Console.WriteLine("Windows Added...");
        }
        public abstract void AddStair();
    }
}
