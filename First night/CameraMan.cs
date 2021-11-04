using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{
    AudioSource music1;
    public Light light;
    public Camera player;
    float xRoc = -90;
    float yRoc;
    float maxRoc = 0;
    float minRoc = - 180;

    bool fonar;
    bool music = false;
    private void Start()
    {
        music1 = GetComponent<AudioSource>();
        music1.Play();
        music1.Pause();
    }
    void Update()
    {
        Position(); 
        if (Input.GetKeyDown("f"))
        {
            fonar = !fonar;
        }
        Fonarik();
        if (Input.GetKeyDown("m"))
        {
            music1.Pause(); 
            
            music = !music;
            if (music) { music1.UnPause(); } 
        }
    }

       void Position()
    {
        //xRoc = Mathf.Clamp(xRoc, minRoc, maxRoc);
        //yRoc = Mathf.Clamp(yRoc, -90, 90);
        if (Input.GetKeyDown("w"))
        {
            xRoc = -90;
            minRoc = -180;
            maxRoc = 0;
        }
        if (Input.GetKeyDown("s"))
        {
            xRoc = 90;
            minRoc = 0;
            maxRoc = 180;
        }
        if (Input.GetKeyDown("d"))
        {
            xRoc = 0;
            minRoc = -90;
            maxRoc = 90;
        }
        if (Input.GetKeyDown("a"))
        {
            xRoc = 180;
            minRoc = 90;
            maxRoc = 270;
        }
        player.transform.rotation = Quaternion.Euler(yRoc, xRoc, 0f);
        light.transform.rotation = Quaternion.Euler(yRoc, xRoc , 0f);

    }    // повороты камеры
       void Fonarik()
    {
        if (fonar)
        {
            light.gameObject.SetActive(false);
        }
        else
        {
            light.gameObject.SetActive(true);
        }
    }
}
