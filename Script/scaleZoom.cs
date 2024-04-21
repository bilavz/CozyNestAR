using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scaleZoom : MonoBehaviour
{
    public Slider sliderScale;
    public Transform transformObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveInterface()
    {
        sliderScale.gameObject.SetActive(true);
    }

    public void ChangeScaleObject()
    {
        transformObject.localScale = new Vector3(sliderScale.value, sliderScale.value, sliderScale.value);
    }
}
