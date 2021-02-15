using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes
{
    public class FactoryLocator : IServiceLocator
    {
        private IDictionary<Type, IService> _factoryRegister;

        public FactoryLocator()
        {
            _factoryRegister = new Dictionary<Type, IService>();
        }
        
        public IService Get<T>() where T : class
        {
            if(!_factoryRegister.ContainsKey(typeof(T)))
            {
                _factoryRegister.Add(typeof(T), new Factory<T>() as IService);
            }

            return _factoryRegister[typeof(T)];
        }
    }
}
