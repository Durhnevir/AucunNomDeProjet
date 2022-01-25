using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Engine.Utils;
public class DataBaseManager : Singleton<DataBaseManager>
{
    [SerializeField] private MobData _easyMobData = null;
    [SerializeField] private MobData _normalMobData = null;
    [SerializeField] private MobData _hardMobData = null;
    [SerializeField] private int _difficulty;
  
 
    public void Initalize()
    {

    }
}
