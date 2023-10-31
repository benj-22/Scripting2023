using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    public float holdTime;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    // Start is called before the first frame update
    private void Start()
    {
        startEvent.Invoke();  
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }

}
