using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataEInterface.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        // Implementa o método e passa ele para abstrato
        public abstract double Area();
    }
}
