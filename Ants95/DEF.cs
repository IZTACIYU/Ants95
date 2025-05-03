using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ants95
{
    interface IProfile
    {
        public void Logics();
    }

    public class Component
    {
        public Component()
        {
            this._component = new Dictionary<Type, Component>();
        }

        private Dictionary<Type, Component> _component;

        public void AddComponent<T>(T component) where T : Component
        {
            this._component[typeof(T)] = component;
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
