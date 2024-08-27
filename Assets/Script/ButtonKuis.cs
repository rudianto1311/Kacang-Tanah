using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonKuis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string menuCredit;

    public void gotoMenuCredit()
    {
        Application.LoadLevel(menuCredit);
    }

    public string mainMenu;

    public void gotoMainMenu()
    {
        Application.LoadLevel(mainMenu);
    }
}
