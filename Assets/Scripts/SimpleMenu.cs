using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMenu : Menu<SimpleMenu> {

    //TODO make this abstract and then derive menus from here

	public static void Show()
    {
        Open();
    }

    public static void Hide()
    {
        Close();
    }

}
