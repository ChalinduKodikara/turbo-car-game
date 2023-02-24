using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightToggle : MonoBehaviour
{
    
    GameObject arObject;
    Toggle m_Toggle;

    void Start()
    {
        arObject = GameObject.FindObjectOfType<CarController>().gameObject;
        m_Toggle = GetComponent<Toggle>();
       
        m_Toggle.onValueChanged.AddListener(delegate {
            arObject.GetComponent<CarLights>().OperateFrontLights();
            Debug.Log("light toggle");
        });
    }

    void Update()
    {
        
    }
}
