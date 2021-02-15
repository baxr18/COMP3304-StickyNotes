using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes
{
    public interface IServiceLocator
    {
        /// <summary>
        /// RETURN a certain type of a factory
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IService Get<T>() where T : class;
    }
}
