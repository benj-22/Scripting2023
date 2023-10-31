using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data",menuName = "Float Data")]

public class FloatData : ScriptableObject
{
    [SerializeField] private float value;

    public void SetValue (float num)
    {
        value = num;
    }
    public float Value
    {
        get {return value;}
        set {this.value = value;}
    }
}
