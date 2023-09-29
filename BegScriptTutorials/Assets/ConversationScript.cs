using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour 
{
    public int intelligence = 5;
    
    
    void Greet()
    {
        switch (intelligence)
        {
        case 5:
            print ("Oh hello! I never learned how to code!");
            break;
        case 4:
            print ("Hello! I know how to code!");
            break;
        case 3:
            print ("Whatchu want?");
            break;
        case 2:
            print ("Uhhhhhhh blubbble..");
            break;
        case 1:
            print ("Kingdom Hearts sucks.");
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        }
    }
}