using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public GameObject UI;            // UI �������
    public CameraMan s;              // ������ �� �������� �������
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
            s.enabled = !s.enabled;         // ���������� � ��� ��������
            UI.gameObject.SetActive(Ser);   // ���� � ��� UI ������
        }
    }
}
