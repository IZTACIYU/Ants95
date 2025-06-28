using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ants95
{
    public class Mono
    {
        public Mono()
        {
            this._component = new Dictionary<Type, Component>();
        }

        private Dictionary<Type, Component> _component;

        public T AddComponent<T>() where T : Component, new()
        {
            T component = new T();
            _component[typeof(T)] = component;

            return component;
        }
        public T GetComponent<T>() where T : Component
        {
            if (this._component.TryGetValue(typeof(T), out Component component))
                return component as T;
            return null;
        }
        public bool TryGetComponent<T>(out T component) where T : Component
        {
            if(this._component.TryGetValue(typeof(T),out Component comp))
            {
                component = comp as T;
                return true;
            }
            component = null;
            return false;
        }
        public bool CheckComponent<T>() where T : Component
        {
            if(this._component.ContainsKey(typeof(T)))
                return true;
            return false;
        }

    }
}
