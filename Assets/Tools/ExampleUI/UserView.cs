using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Views;

public class UserView : ViewBase
{
    [SerializeField] private Image userPic;
    [SerializeField] private TMP_Text userName;
    
    public Image UserPic => userPic;
    public TMP_Text UserName => userName;
}
