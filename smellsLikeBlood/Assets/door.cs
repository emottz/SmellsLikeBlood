using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    public AudioSource sound;

    public void Door()
    {

        sound.Play();

    }
    public void Door_()
    {

        sound.Stop();

    }
}
