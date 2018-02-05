using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.metier
{
    class EmptyException : Exception
    {

       
        public EmptyException(String message): base(message)
        {
           
        }


    }
}
