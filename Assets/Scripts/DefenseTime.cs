using UnityEngine;
using UnityEngine.UI;

public class DefenseTime : MonoBehaviour
{
    public Text time;
    public VariableData data;

    void Update() {
        time.text = data.defenseTime.ToString("0");
    }
}