using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndgameData : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public float climbPosition = 0;
    public string comment = "";
    public bool climb = false;
    public bool park = false;

    public void climbed() {
        climb = !climb;
    }
    public void parked() {
        park = !park;
    }
    public void climbPos(float pos) {
        climbPosition = pos;
    }

    public void enterComment(string com) {
        comment = com;
    }

    void Update() {
        if(SceneManager.GetActiveScene().buildIndex == 0) {
            Destroy(gameObject);
        }
    }
}
