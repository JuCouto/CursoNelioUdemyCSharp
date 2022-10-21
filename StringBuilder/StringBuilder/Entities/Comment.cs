using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExercicio.Entities
{
    internal class Comment
    {
        public string Texto { get; set; }

        public Comment()
        {

        }

        public Comment(string texto)
        {
            Texto = texto;
        }
    }

}
