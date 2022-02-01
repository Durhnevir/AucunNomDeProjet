using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTest : MonoBehaviour
{
    private bool _isPause;
    void Start()
    {
        GameLoopManager.Instance.OnEarlyUpdate += GameLoop;
        GameLoopManager.Instance.OnPause += OnPause;
    }

    // Update is called once per frame
    void GameLoop()
    {
        Debug.Log("Up");
    }
    void OnPause()
    { if (_isPause == false)
        {
            GameLoopManager.Instance.OnEarlyUpdate -= GameLoop;
        }
        if (_isPause == true)
        {
            GameLoopManager.Instance.OnEarlyUpdate += GameLoop;
        }
        _isPause = ! _isPause; 
    }
}
