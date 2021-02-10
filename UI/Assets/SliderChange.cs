using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderChange : MonoBehaviour
{
    [SerializeField] private Slider slider;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.slider.value += 0.01f;
    }
}
