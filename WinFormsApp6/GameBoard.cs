using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    internal class GameBoard
    {
        public int GameBoardID { get; set; }
        public string Name { get; set; }
        public float Rate { get; set; }
        public float Complexity { get; set; }
        public override string ToString()
        {
            return $"({GameBoardID}) {Name}:\t {Rate}";
        }
    }
}
