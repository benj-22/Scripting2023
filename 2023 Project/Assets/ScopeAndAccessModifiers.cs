using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    // Variables in a class have an access modifier attributed to them
    public int alpha; //if OTHER scripts need access to this variable, it should be public
    
    private int beta = 0; //otherwise, it should be private
    private int gamma = 5; //private is the default for C#

    private AnotherClass my myOtherClass;

    void Start()
    {
        alpha = 29; /* Since this is in the Start function, it will override what's been written
                        in the inspector */

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
