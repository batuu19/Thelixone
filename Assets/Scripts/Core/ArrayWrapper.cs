using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Giereczka.Core
{
    [Serializable]
    public class ArrayWrapper<T>
    {
        [SerializeField]
        private T[] _array;

        public T[] Array { get => _array; set => _array = value; }

        public static ArrayWrapper<T> Get(T[] array)
        {
            return new ArrayWrapper<T>()
            {
                Array = array
            };
        }

    }
}
