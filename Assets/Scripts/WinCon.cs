using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour
{
    public int WinCount = 0;
    public GameObject[] Keys;
    // Start is called before the first frame update
    void Start()
    {
        Keys = GameObject.FindGameObjectsWithTag("Key");
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Monster")
        {
            Debug.Log("You Lose");
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }
        if(other.tag == "Key")
        {
            WinCount = WinCount + 1;
        }
        if(other.tag == "Exit" && WinCount == 3)
        {
            Debug.Log("You Win");
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }
    }
    // Update is called once per frame
    void Update()
    {
        foreach(GameObject Key in Keys)
        {
            if (Key.activeInHierarchy == false)
            {

            }
        }
    }
}
