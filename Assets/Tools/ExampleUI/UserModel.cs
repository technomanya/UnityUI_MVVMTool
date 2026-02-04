using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEngine;

public class UserModel : ModelBase
{
    
    public UIDataSo uiData;
    public UserModel(UIDataSo data)
    {
        uiData = data;
        uiData.DataChangedEvent += OnPropertyChanged;
    }

    private void OnPropertyChanged()
    {
        OnPropertyChanged( nameof(uiData));
    }
}
