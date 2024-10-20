using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OpenGameLevel()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void OpenInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
