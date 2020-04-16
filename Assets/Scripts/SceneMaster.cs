using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMaster : MonoBehaviour
{
    public void nextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void resetScene() {
        SceneManager.LoadScene(0);
    }
}