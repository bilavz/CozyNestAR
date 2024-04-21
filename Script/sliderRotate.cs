using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderRotate : MonoBehaviour
{
    public Slider sliderRotateObject;
    GameObject targetRotate;
    public float rotateLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotateObject()
    {
        targetRotate.transform.localEulerAngles = new Vector3(0f, sliderRotateObject.value * rotateLimit,0f);
    }

    public void TargetFound(GameObject target)
    {
        sliderRotateObject.interactable = true; // mengaktifkan ui slider

        targetRotate = target;
    }

    public void TargetLost()
    {
        sliderRotateObject.interactable = false; // mematikan ui slider

        sliderRotateObject.value = 0;

        if(targetRotate is null)
        {
            targetRotate.transform.localEulerAngles = Vector3.zero;
        }

        targetRotate = null;
    }

    public void ActiveInterface()
    {
        sliderRotateObject.gameObject.SetActive(true);
    }
}
