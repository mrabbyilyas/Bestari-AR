using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip ARMain_SFX, ARTejo_SFX, Back_SFX;
    public void ARMainSFX()
    {
        audioSource.clip = ARMain_SFX;
        audioSource.Play();
    }

    public void ARTejoSFX()
    {
        audioSource.clip = ARTejo_SFX;
        audioSource.Play();
    }

    public void BackSFX()
    {
        audioSource.clip = Back_SFX;
        audioSource.Play();
    }
}
