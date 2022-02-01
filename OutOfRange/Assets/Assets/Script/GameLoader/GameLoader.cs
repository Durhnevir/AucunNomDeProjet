using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoaderDebug : MonoBehaviour
{
    private void Start()
    {
        DataBaseManager.Instance.Initalize();
        SceneManager.LoadScene("Game");
    }
}