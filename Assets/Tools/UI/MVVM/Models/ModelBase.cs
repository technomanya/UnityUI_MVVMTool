using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Models
{
    public abstract class ModelBase
    {
        public event Action<string> PropertyChanged;
        
        protected void OnPropertyChanged(string propertyName = null)//This method can be overloaded to provide custom logic for property change notifications
        {
            PropertyChanged?.Invoke(propertyName);
        }
    }
}
