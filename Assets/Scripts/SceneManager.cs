using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//public class SceneManager : MonoBehaviour
public class SceneLoad : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("RoomEscape");
    }

    public void QuitGame() {
    	Application.Quit();
    }
}
