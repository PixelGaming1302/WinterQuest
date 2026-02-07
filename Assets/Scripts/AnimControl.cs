using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject Pixel;

    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            Pixel.GetComponent<Animator>().Play("PixelWalk");
        }
        if (Input.GetButtonDown("Vertical"))
        {
            Pixel.GetComponent<Animator>().Play("PixelWalk");
        }
        if (Input.GetButtonUp("Vertical"))
        {
            Pixel.GetComponent<Animator>().Play("PixelIdle");
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            Pixel.GetComponent<Animator>().Play("PixelIdle");
        }
        
    }
}