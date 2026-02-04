using System;
using UnityEngine;

[CreateAssetMenu(fileName = "UIData", menuName = "Data", order = 1)]
public class UIDataSo : ScriptableObject
{
    public Sprite userPicSprite;
    public string userName;

    public event Action DataChangedEvent;
    
    public void OnDataChanged()
    {
        DataChangedEvent?.Invoke();
    }
}
