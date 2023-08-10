using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARSceneTweening : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject back_button, instruction;

    void Start()
    {
        LeanTween.moveLocal(back_button, new Vector3(0f, 0f, 0f), .7f).setDelay(1f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(instruction, new Vector3(0f, 0f, 0f), .7f).setDelay(1f).setEase(LeanTweenType.easeInOutCubic);
    }
}
