using UnityEngine;
using UnityEngine.UI;

public class ScoreInformationText : MonoBehaviour
{
    public Text scoreinfo;
    void Start() {
        scoreinfo.text = "High Cells: " + FindObjectOfType<VariableData>().autonHighCells.ToString() + " auton, " + FindObjectOfType<VariableData>().teleopHighCells.ToString() + " teleop." + "\n" +
        "Low Cells: " + FindObjectOfType<VariableData>().autonLowCells.ToString() + " auton, " + FindObjectOfType<VariableData>().teleopLowCells.ToString() + " teleop." + "\n" +
        "Drops: " + FindObjectOfType<VariableData>().autonDrops.ToString() + " auton, " + FindObjectOfType<VariableData>().teleopDrops.ToString() + " teleop." + "\n" + 
        "Rotation: " + FindObjectOfType<VariableData>().rotation.ToString() + " Position: " + FindObjectOfType<VariableData>().position.ToString() + "\n" +
        "Defense Time: " + FindObjectOfType<VariableData>().defenseTime.ToString() + " Bricked Time: " + FindObjectOfType<VariableData>().brickedTime.ToString() + "\n" +
        "Climbed: " + FindObjectOfType<EndgameData>().climb.ToString() + "\n" + 
        "Comment: " + FindObjectOfType<EndgameData>().comment;
    }
}
