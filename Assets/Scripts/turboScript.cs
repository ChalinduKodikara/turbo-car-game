using UnityEngine;
using UnityEngine.EventSystems;

public class turboScript :  MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    GameObject arObject;
    
    void Start()
    {
        arObject = GameObject.FindGameObjectWithTag("Car");
    }

    
    public void OnPointerDown(PointerEventData eventData)
    {

        arObject.GetComponent<CarController>().MoveInput(100);
           
    }

    public void OnPointerUp(PointerEventData eventData)
    {
            arObject.GetComponent<CarController>().MoveInput(0);
    }

}
