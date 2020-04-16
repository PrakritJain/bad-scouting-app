using UnityEngine;
using UnityEngine.SceneManagement;

public class VariableData : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    
    public int autonHighCells = 0;
    public int teleopHighCells = 0;
    public int autonLowCells = 0;
    public int teleopLowCells = 0;
    public int autonDrops = 0;
    public int teleopDrops = 0;
    public bool rotation = false;
    public bool position = false;
    public bool defense = false;
    public float defenseTime = 0f;
    public bool bricked = false;
    public float brickedTime = 0f;
    public bool auton = true;
    public float climbPos = 0;
    public void plusHigh() {
        if(auton == true) {
            autonHighCells++;
        }
        else {
            teleopHighCells++;
        }
    }
    public void minusHigh() {
        if(auton == true & autonHighCells > 0) {
            autonHighCells--;
        }
        else if(teleopHighCells > 0) {
            teleopHighCells--;
        }

    }
    public void plusLow() {
        if(auton == true) {
            autonLowCells++;
        }
        else {
            teleopLowCells++;
        }
    }
    public void minusLow() {

        if(auton == true & autonLowCells > 0) {
            autonLowCells--;
        }
        else if(teleopLowCells > 0) {
            teleopLowCells--;
        }
    }
    public void plusDrop() {
        if(auton == true) {
            autonDrops++;
        }
        else {
            teleopDrops++;
        }
    }
    public void minusDrop() {
        if(auton == true & autonDrops > 0) {
            autonDrops--;
        }
        else if(teleopDrops > 0) {
            teleopDrops--;
        }
    }
    public void rotControl() {
        rotation = !rotation;
    }
    public void posControl() {
        position = !position;
    }
    public void defenseOn() {
        defense = !defense;
    }
    public void brickedOn() {
        bricked = !bricked;
    }
    public void switchAuton() {
        auton = !auton;
    }
    void Update() {
        if(defense == true) {
            defenseTime += Time.deltaTime;
        }
        if(bricked == true) {
            brickedTime += Time.deltaTime;
        }
        if(SceneManager.GetActiveScene().buildIndex == 0) {
            Destroy(gameObject);
        }
    }
}