using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    public class Paper : Shape
    {
        public Paper()
        {
            Name = "Papír";
            Image = Properties.Resources.paper;
        }
    }
}
