using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    private void onTriggerEnter(Collider other)
    {
        Debug.Log(idObj);
    }
}
