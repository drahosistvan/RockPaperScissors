using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    public abstract class Shape
    {
        public string Name { get; internal set; }
        public Image Image { get; internal set; }
    }
}
