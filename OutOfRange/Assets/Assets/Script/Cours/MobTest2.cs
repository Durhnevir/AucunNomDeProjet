using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTest2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameLoopManager.Instance.OnUpdate += GameLoop;
        
    }

    // Update is called once per frame
    void GameLoop()
    {
        Debug.Log("Non");
    }
}
