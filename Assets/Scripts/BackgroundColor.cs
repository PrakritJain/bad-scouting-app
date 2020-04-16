using UnityEngine;
using System.Collections;

public class BackgroundColor : MonoBehaviour
{
    Color autonColor = new Color(0.5431f, 0.5081f, 0.5471f);
    Color teleopColor = new Color(0.5107f, 0.5566f, 0.4174f);

    public Camera cm;
    public VariableData data;

    void Update()
    {
        if(data.auton == true) {
            cm.backgroundColor = autonColor;
        }
        else {
            cm.backgroundColor = teleopColor;
        }
    }
}