using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class intData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void SetValue(intData obj)
    {
        value = obj.value;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }
}
