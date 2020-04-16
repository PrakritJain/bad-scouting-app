using UnityEngine;
using UnityEngine.UI;

public class LowCellText : MonoBehaviour
{
    public Text cellCount;
    public VariableData data;

    void Update() {
        if(data.auton == true) {
            cellCount.text = data.autonLowCells.ToString() + " auton low cells";
        }
        else {
            cellCount.text = data.teleopLowCells.ToString() + " teleop low cells";
        }
    }
}