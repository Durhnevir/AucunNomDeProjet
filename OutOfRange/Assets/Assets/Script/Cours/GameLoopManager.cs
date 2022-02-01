using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Engine.Utils;
using System;

public class GameLoopManager : Singleton<GameLoopManager>
{
    #region Events
    private event Action _onEarlyUpdate = null;
    public event Action OnEarlyUpdate
    {
        add
        {
            _onEarlyUpdate -= value;
            _onEarlyUpdate += value;

        }
        remove
        {
            _onEarlyUpdate -= value;
        }
    }
    private event Action _onUpdate = null;
    public event Action OnUpdate
    {
        add
        {
            _onUpdate -= value;
            _onUpdate += value;

        }
        remove
        {
            _onUpdate -= value;
        }
    }
    private event Action _onUpdateFixed = null;
    public event Action OnUpdateFixed
    {
        add
        {
            _onUpdateFixed -= value;
            _onUpdateFixed += value;

        }
        remove
        {
            _onUpdateFixed -= value;
        }
    }
    private event Action _onPause= null;
    public event Action OnPause
    {
        add
        {
            _onPause-= value;
            _onPause += value;

        }
        remove
        {
            _onPause -= value;
        }
    }
    #endregion
    private void Update()
    {
        if (_onEarlyUpdate != null)
        {
            _onEarlyUpdate();
        }
        if (Input.GetKeyDown(KeyCode.Space ) && _onPause != null)
        {
            _onPause();
        }
        if (_onUpdate != null)
        {
            _onUpdate();
        }
    }
    private void FixedUpdate()
    {
        if (_onUpdateFixed != null)
        {
            _onUpdateFixed();
        }
    }
}


