using UnityEngine;
using UnityEngine.EventSystems;

public class CarMoves : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    GameObject arObject;
    public int moveOrSteer; //steer = 1, move = 0
    public int upOrDown; //down = 1, up = 0
    
    void Start()
    {
        arObject = GameObject.FindGameObjectWithTag("Car");
    }

    
    public void OnPointerDown(PointerEventData eventData)
    {
        if(moveOrSteer == 0){
            if(upOrDown == 0){
                arObject.GetComponent<CarController>().MoveInput(1);
            }
            else if(upOrDown == 1){
                arObject.GetComponent<CarController>().MoveInput(-1);
            }
            
        }
        else if(moveOrSteer == 1){
            if(upOrDown == 0){
                arObject.GetComponent<CarController>().SteerInput(1);
            }
            else if(upOrDown == 1){
                arObject.GetComponent<CarController>().SteerInput(-1);
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if(moveOrSteer == 0){
            arObject.GetComponent<CarController>().MoveInput(0);
        }
        else if(moveOrSteer == 1){
            arObject.GetComponent<CarController>().SteerInput(0);
        }
        
    }

}