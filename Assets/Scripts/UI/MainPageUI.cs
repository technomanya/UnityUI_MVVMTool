using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPageUI : MonoBehaviour
{
    [SerializeField] UserViewModel userViewModel;
    
    [SerializeField] Button userButton;

    private void Start()
    {
        userButton.onClick.AddListener(OpenUserPage);
    }

    private void OpenUserPage() => userViewModel.Show();
}
