using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null) 
            return; //return means don't run the rest of the stuff below in the class

        var otherID = tempObj.idObj;
        /*Debug.Log(otherID == idObj ? "It's a match!" : "Not a match");

        this is apparently the same as this 

        if (otherID == idObj)
        {
            Debug.Log("It's a match!");
        }
        else
        {
            Debug.Log("Not a match :("); 

        }*/

        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke(); 

        }

    }
}
