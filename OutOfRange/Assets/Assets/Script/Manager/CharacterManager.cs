using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Engine.Utils;

public class CharacterManager : Singleton<CharacterManager>
{
   
    private CharacterController _character = null;
    public CharacterController Character
    {
        get
        {
            return _character;

        }
        set
        {
            _character = value;
        }
    }
}
