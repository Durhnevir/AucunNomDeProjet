using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : BasicState
{
    public override void Enter(StateManager state)
    {
        Debug.Log("We enter in the Idle");
        state.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    public override void Update(StateManager state)
    {
       
    }
        
        
    public override void Exit(StateManager state)
    {
        Debug.Log("We exit the Idle");
    }
}
