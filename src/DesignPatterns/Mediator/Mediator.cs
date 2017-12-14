using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Mediator
    {
        private Dictionary<string, List<Delegate>> methods = new Dictionary<string, List<Delegate>>();
        
        public void Register(string name, Action action)
        {
            if (!methods.ContainsKey(name))
            {
                methods[name] = new List<Delegate>();
            }
            methods[name].Add(action);
        }

        public void Register<T>(string name, Func<T> action)
        {
            if (!methods.ContainsKey(name))
            {
                methods[name] = new List<Delegate>();
            }
            if (methods[name].Count >= 1)
            {
                throw new ArgumentException("Too many methods with same name");
            }
            methods[name].Add(action);
        }

        public void Send(string name)
        {
            if (methods.ContainsKey(name))
            {
                foreach (Action action in methods[name])
                {
                    action.DynamicInvoke();
                }
            }
        }

        public T Send<T>(string name)
        {
            if (methods.ContainsKey(name))
            {
                return (T)methods[name].First().DynamicInvoke();
            }

            return default(T);
        }
    }
}
