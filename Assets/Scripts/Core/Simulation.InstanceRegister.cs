using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giereczka.Core
{
    public static partial class Simulation
    {
        /// <summary>
        /// This class provides a container for creating singletons for any other class,
        /// within the scope of the Simulation. It is typically used to hold the simulation
        /// models and configuration classes.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        static class InstanceRegister<T> where T : class, new()
        {
            public static T instance = new T();
        }
    }
}
