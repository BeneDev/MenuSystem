using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleMenu : Menu<SimpleMenu> {

    //TODO make this abstract and then derive menus from here

    [SerializeField] private Button button;

    public static void Show()
    {
        Open();

        Instance.button.onClick.AddListener(delegate { Debug.Log("Clicked"); });
    }

    public static void Hide()
    {
        Close();
    }

    public void OpenOptions()
    {
        OptionsMenu.Show();
    }

}
