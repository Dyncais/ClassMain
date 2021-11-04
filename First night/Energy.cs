using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    float nalog;
    float nalog1;
    public float power;
    public NachatieKnopki per;
    public NachatieKnopki per2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        nalog = per.k;
        nalog1 = per2.k;
        power -= 0.0002f + nalog + nalog1;
    }
}
