using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModels;

public class UserViewModel : ViewModelBase<UserModel, UserView>
{
    public string dataPath;
    [SerializeField] private UserView view;
    void Start()
    {
        if(!view) view = GetComponent<UserView>();
        var data = Resources.Load<UIDataSo>(dataPath);
        var model = new UserModel(data);
        
        Initialize(model, view);
    }
    
    protected override void UpdateView()
    {
        view.UserPic.sprite = Model.uiData.userPicSprite;
        view.UserName.text = $"User name:  {Model.uiData.userName}";
    }
}
