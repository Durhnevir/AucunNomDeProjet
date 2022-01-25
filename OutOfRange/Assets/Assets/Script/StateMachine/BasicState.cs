using UnityEngine;

public abstract class BasicState 
{
   /* protected StateManager _manager = null;
    public BasicState(StateManager manager)
    {
        _manager = manager;
    }*/


   public abstract void Enter(StateManager state);

   public abstract void Update(StateManager state);
  
   public abstract void Exit(StateManager state);
    
           
}
