using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateManager  : MonoBehaviour
{
    private BasicState _currentState;
    private Idle _idle = new Idle();
    private Run _run = new Run();
    private Dictionary<EnumState, BasicState> _dic = null;
    private EnumState _enumState;



public BasicState CurrentState => _dic[ _enumState];

  
    public void Start()
    {
       _dic = new Dictionary<EnumState, BasicState>();
       _dic.Add(EnumState.RUN, _run);
       _dic.Add(EnumState.IDLE, _idle);


        _currentState = _idle;


        _currentState.Enter(this);

    }
    private void Update()
    {
        
        _currentState.Update(this);

        if(Input.GetKeyDown(KeyCode.R))
        {
            
            SwitchState(EnumState.RUN);
        } 
        else if(Input.GetKeyDown(KeyCode.I))
        {

            SwitchState(EnumState.IDLE);
        } 
       
    }
    public void SwitchState(EnumState state)
    {
        CurrentState.Exit(this);
        _enumState = state;
        
        CurrentState.Enter(this);
    }

}
