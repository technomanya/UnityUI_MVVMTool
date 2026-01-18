using System;
using UnityEngine;

namespace Models
{
    public abstract class ModelBase
    {
        public event Action<string> PropertyChanged;
    
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(propertyName);
        }
    }
}
