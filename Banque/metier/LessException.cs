using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.metier
{
    class LessException : Exception
    {

       
        public LessException(String message): base(message)
        {
           
        }


    }
}
