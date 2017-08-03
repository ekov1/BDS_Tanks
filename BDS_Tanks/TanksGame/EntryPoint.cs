using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core;

namespace TanksGame
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Engine.Instance.Run();
        }
    }
}
