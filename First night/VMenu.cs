using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VMenu : MonoBehaviour
{
    public void Menu()
    {
        Application.LoadLevel("Menu");
    }
    public void Vihod()
    {
        Application.Quit();
    }
}
