using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO20_GetHashCode.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                throw new ArgumentException("The type of argument is not a Client");
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
