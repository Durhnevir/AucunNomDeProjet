using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MobData", menuName ="Database/MobData")]
public class MobData : ScriptableObject
{
    [SerializeField] private int _hpMax = 100;
    [SerializeField] private int _damage = 100;
    [SerializeField] private int _armor = 100;

    public int HpMax => _hpMax;
    public int Damage =>_damage;
    public int Armor => _armor;
    
}
