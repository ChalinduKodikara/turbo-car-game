using UnityEngine;
using UnityEngine.EventSystems;

public class CarBreak : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    GameObject arObject;
    void Start()
    {
        arObject = GameObject.FindGameObjectWithTag("Car");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        arObject.GetComponent<CarController>().BreakInput(1);   
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        arObject.GetComponent<CarController>().BreakInput(0);
    }
}
