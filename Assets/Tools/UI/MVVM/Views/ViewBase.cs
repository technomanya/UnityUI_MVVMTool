using Models;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Serialization;
using UnityEngine.UI;
using ViewModels;

namespace Views
{
    public abstract class ViewBase : MonoBehaviour
    {
        public GameObject viewElement;
        
        public event Action OnCloseRequested;
    
        protected void RaiseCloseRequested() => OnCloseRequested?.Invoke();
    }
}
