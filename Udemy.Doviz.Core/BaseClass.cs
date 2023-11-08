using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Doviz.Core
{
    public class BaseClass
    {
        public void ControlException(Action action)
        {
            try 
            { 
                action(); 
            } 
            catch(Exception ex) 
            {
                // Loglama işlemleri burada olacak ...
            } 
        }
    }
}
