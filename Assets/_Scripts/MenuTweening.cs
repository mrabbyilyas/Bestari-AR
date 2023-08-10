using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTweening : MonoBehaviour
{
    [SerializeField] GameObject Title, ARTejo, ARMain, Kredit, Exit;

    void Start()
    {
        LeanTween.scale(Title, new Vector3(1f, 1f, 1f), 2f).setDelay(1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(Title, new Vector3(0f, 0f, 0f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);

        LeanTween.moveLocal(ARTejo, new Vector3(0f, 60f, 0f), .7f).setDelay(2.5f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(ARMain, new Vector3(0f, 20f, 0f), .7f).setDelay(2.9f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(Kredit, new Vector3(0f, -20f, 0f), .7f).setDelay(3.3f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(Exit, new Vector3(0f, -60f, 0f), .7f).setDelay(3.7f).setEase(LeanTweenType.easeInOutCubic);
    }
}
