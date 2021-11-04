using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NachatieKnopki : MonoBehaviour, IPointerClickHandler
{
    public GameObject vhod;
    public float k;
    public int car;
    bool aktivno = false;
    public void OnPointerClick(PointerEventData evendata)
    { aktivno = !aktivno; }

    void Update()
    {
        akt();
    }
    void akt()
    {
        if (aktivno)
        {
            k = 0.0003f;
            vhod.transform.rotation = Quaternion.Euler(0, car, 0);
        }
        else
        {
            k = 0f;
            vhod.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}

