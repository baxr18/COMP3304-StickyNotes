using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes
{
    /// <summary>
    /// IMPLEMENT a factory to create specific implementations of an object
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public class Factory<E> : IFactory<E>
    {
        /// <summary>
        /// INSTANTIATE a new factory object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public E Create<T>() where T : E, new()
        {
            return new T();
        }
    }
}
