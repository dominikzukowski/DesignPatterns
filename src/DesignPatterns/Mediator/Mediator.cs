using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Mediator
    {
        private Dictionary<string, Delegate> methods = new Dictionary<string, Delegate>();
        
        public void Register(string name, Action action)
        {
            methods.Add(name, action);
        }

        public void Send(string name)
        {
            methods[name].DynamicInvoke();
        }
    }
}
