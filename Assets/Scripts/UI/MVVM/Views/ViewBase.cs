using UnityEngine;
using System;
using UnityEngine.UI;

namespace Views
{
    public abstract class ViewBase : MonoBehaviour
    {
        public GameObject viewElement;
        [SerializeField] protected Button closeButton;
        
        public event Action OnCloseRequested;
    
        protected void RaiseCloseRequested() => OnCloseRequested?.Invoke();

        private void Start()
        {
            if (closeButton)
                closeButton.onClick.AddListener(RaiseCloseRequested);
        }
        private void OnDestroy()
        {
            if (closeButton)
                closeButton.onClick.RemoveListener(RaiseCloseRequested);
        }
    }
}
