using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject SkPanel;
    public GameObject MateriPanel;
    public GameObject infoPanel;
    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        SkPanel.SetActive(false);
        MateriPanel.SetActive(false);
        infoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SkButton()
    {
        MenuPanel.SetActive(false);
        SkPanel.SetActive(true);
    }

    public void KembaliButtonSK()
    {
        MenuPanel.SetActive(true);
        SkPanel.SetActive(false);
    }

    public void MateriButton()
    {
        MenuPanel.SetActive(false);
        MateriPanel.SetActive(true);
    }

    public void KembaliButtonMateri()
    {
        MenuPanel.SetActive(true);
        MateriPanel.SetActive(false);
    }

    public void InfoButton()
    {
        MenuPanel.SetActive(false);
        infoPanel.SetActive(true);
    }

    public void KembaliButtonInfo()
    {
        MenuPanel.SetActive(true);
        infoPanel.SetActive(false);
    }

    public void Keluar()
    {
        Application.Quit();
        Debug.Log("Quitting");

    }

    public void mulaiLatihan(string sceneLatihan)
    {
        SceneManager.LoadScene(sceneLatihan);
    }

    public void ulangiLatihan(string sceneUlangiLatihan)
    {
        SceneManager.LoadScene(sceneUlangiLatihan);
    }

    public void MainMenu(string sceneMainMenu)
    {
        SceneManager.LoadScene(sceneMainMenu);
    }
}
