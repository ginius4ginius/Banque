using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.metier
{
    class TypeException : Exception
    {

       
        public TypeException(String message): base(message)
        {
           
        }


    }
}
