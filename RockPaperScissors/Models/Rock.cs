using RockPaperScissors.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    public class Rock : Shape
    {
        public Rock()
        {
            Name = "Kő";
            Image = Properties.Resources.rock;
        }
    }
}
