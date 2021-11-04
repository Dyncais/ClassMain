using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Win();
    }
    void Win()
    {
        time += 0.0001f;
        if (time == 1f)
        {
            Debug.Log("≈бать ты молодец");
        }
    }
}
