using UnityEngine;
using UnityEngine.UI;

public class DropText : MonoBehaviour
{
    public Text cellCount;
    public VariableData data;

    void Update() {
        if(data.auton == true) {
            cellCount.text = data.autonDrops.ToString() + " auton drops";
        }
        else {
            cellCount.text = data.teleopDrops.ToString() + " teleop drops";
        }
    }
}