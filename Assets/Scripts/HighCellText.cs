using UnityEngine;
using UnityEngine.UI;

public class HighCellText : MonoBehaviour
{
    public Text cellCount;
    public VariableData data;

    void Update() {
        if(data.auton == true) {
            cellCount.text = data.autonHighCells.ToString() + " auton high cells";
        }
        else {
            cellCount.text = data.teleopHighCells.ToString() + " teleop high cells";
        }
    }
}