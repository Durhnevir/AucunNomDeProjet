using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : BasicState
{
    public override void Enter(StateManager state)
    {
        Debug.Log("Enter In Run");
        state.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
  public override void Update(StateManager state)
    {

    }
   public override void Exit(StateManager state)
    {
        Debug.Log("We exit the Run");
    }

}
