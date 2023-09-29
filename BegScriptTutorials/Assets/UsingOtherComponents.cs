using UnityEngine;
using System.Collections;
//scripts are custom components
//access using GetComponent
//GetComponent takes a lot of processing power--> Use only when
    //needed and use in awake class so you only use it once

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    
    
    private AnotherScript anotherScript; //variables w/ name of script
    //accesses the class with the same name as script
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    
    
    void Awake ()
    {
        anotherScript = GetComponent<AnotherScript>();
        //<> is for taking the type as a parameter
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    
    void Start ()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}