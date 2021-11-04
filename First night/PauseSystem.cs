using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public GameObject UI;            // UI элемент
    public CameraMan s;              // скрипт на движение камерой
    bool Ser = false;

    private void Start()
    {
        UI.gameObject.SetActive(false);
    }
    private void Update()
    {
        Escape();
    }
    void Escape()
    {
        if (Input.GetKeyDown("escape"))
        {
            Ser = !Ser;
            s.enabled = !s.enabled;         // отключение и вкл движения
            UI.gameObject.SetActive(Ser);   // откл и вкл UI кнопок
        }
    }
}
