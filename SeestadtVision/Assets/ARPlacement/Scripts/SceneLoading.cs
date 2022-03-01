using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public void LoadSceneARNode()
    {
        SceneManager.LoadScene("NoteMode");
    } 

    public void LoadSceneARPlacementMode()
    {
        SceneManager.LoadScene("ARPlacementMode");
    }

    public void LoadSceneImageMode()
    {
        SceneManager.LoadScene("PictureSwapMode");
    }
}
