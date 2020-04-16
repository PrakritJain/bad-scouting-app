using UnityEngine;
using UnityEngine.UI;

public class BrickedTime : MonoBehaviour
{
    public Text time;
    public VariableData data;

    void Update() {
        time.text = data.brickedTime.ToString("0");
    }
}