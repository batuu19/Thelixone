using System;
using System.Collections.Generic;
using UnityEngine;


namespace Giereczka.Core
{
    /// <summary>
    /// The Simulation class NOW DOES NOT implements the discrete event simulator pattern.
    /// Events are pooled, with a default capacity of 4 instances.
    /// </summary>
    public static partial class Simulation
    {

        //do I need instance register?

        /// <summary>
        /// Return the simulation model instance for a class.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        static public T GetModel<T>() where T : class, new()
        {
            return InstanceRegister<T>.instance;
        }

        /// <summary>
        /// Set a simulation model instance for a class.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        static public void SetModel<T>(T instance) where T : class, new()
        {
            InstanceRegister<T>.instance = instance;
        }

        /// <summary>
        /// Destroy the simulation model instance for a class.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        static public void DestroyModel<T>() where T : class, new()
        {
            InstanceRegister<T>.instance = null;
        }
    }
}



