using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUtility : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void LoadScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void QuitGame()
    {
        Debug.Log("GameQuit");
        Application.Quit();
    }
}
