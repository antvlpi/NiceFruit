using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayProssed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitProssed()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
