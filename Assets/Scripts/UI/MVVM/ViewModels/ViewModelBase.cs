using System;
using Models;
using UnityEngine;
using Views;

namespace ViewModels
{
    public abstract class ViewModelBase<TModel, TView> : MonoBehaviour
        where TModel : ModelBase
        where TView : ViewBase
    {
        private TModel _model;
        private TView _view;
    
        public TModel Model => _model;
        public TView View => _view;
        
        public void Initialize(TModel model, TView view)
        {
            if (_model != null || _view != null) return;
            
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _view = view ?? throw new ArgumentNullException(nameof(view));
        
            SubscribeToModel();
            OnInitialized();
            UpdateView();
        }
    
        protected virtual void SubscribeToModel()
        {
            _model.PropertyChanged += OnModelPropertyChanged;
        }
    
        protected virtual void OnModelPropertyChanged(string propertyName)
        {
            UpdateView();
        }

        protected virtual void OnInitialized()
        {
            _view.OnCloseRequested += Hide;
        }
        protected abstract void UpdateView();

        public virtual void Show()
        {
            if (View?.viewElement)
                    View.viewElement.SetActive(true);
        }
        public virtual void Hide()
        {
            if (View?.viewElement)
                View.viewElement.SetActive(false);
        }
    
        protected virtual void OnDestroy()
        {
            if (_model != null)
                _model.PropertyChanged -= OnModelPropertyChanged;
            
            if(_view)
                _view.OnCloseRequested -= Hide;
        }
    }
}
