using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConjuntos.Entities
{
    internal class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        // O critério de igualdade está somente no username, posso colocar quantos quiser.
        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord))
            {
                return false;
            }

            // Downcasting
            LogRecord other = obj as LogRecord;
            return UserName.Equals(other.UserName);
        }
    }
}
