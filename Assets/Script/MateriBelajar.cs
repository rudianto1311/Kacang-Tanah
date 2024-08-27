using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateriBelajar : MonoBehaviour
{
    public GameObject MateriPanel1;
    public GameObject MateriPanel2;
    public GameObject MateriPanel3;
    public GameObject MateriPanel4;

    // Start is called before the first frame update
    void Start()
    {
        MateriPanel1.SetActive(false);
        MateriPanel2.SetActive(false);
        MateriPanel3.SetActive(false);
        MateriPanel4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MateriButton1()
    {
        if (MateriPanel1 != null)
        {
            bool isActive = MateriPanel1.activeSelf;
            MateriPanel1.SetActive(!isActive);
            MateriPanel2.SetActive(false);
            MateriPanel3.SetActive(false);
            MateriPanel4.SetActive(false);
        }
    }
    public void MateriButton2()
    {
        if (MateriPanel2 != null)
        {
            bool isActive = MateriPanel2.activeSelf;
            MateriPanel2.SetActive(!isActive);
            MateriPanel1.SetActive(false);
            MateriPanel3.SetActive(false);
            MateriPanel4.SetActive(false);
        }
    }

    public void MateriButton3()
    {
        if (MateriPanel3 != null)
        {
            bool isActive = MateriPanel3.activeSelf;
            MateriPanel3.SetActive(!isActive);
            MateriPanel1.SetActive(false);
            MateriPanel2.SetActive(false);
            MateriPanel4.SetActive(false);
        }
    }
    public void MateriButton4()
    {
        if (MateriPanel4 != null)
        {
            bool isActive = MateriPanel4.activeSelf;
            MateriPanel4.SetActive(!isActive);
            MateriPanel1.SetActive(false);
            MateriPanel2.SetActive(false);
            MateriPanel3.SetActive(false);
        }
    }
}
