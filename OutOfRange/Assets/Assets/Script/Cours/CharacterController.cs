using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private int _hpMax = 10;
    private event Action <float, int> _onHpChange = null;
    public event Action <float,int> OnHpChange
    {
        add
        { 
            _onHpChange -= value;
            _onHpChange += value;
        }
        remove
        {
            _onHpChange -= value;
        }
    }

    public int HpMax => _hpMax;
    private int _currentHp;
    public int CurrentHp
    {
        get => _currentHp;
        
        set
        {
           
            _currentHp = value;
            _currentHp = Mathf.Clamp(_currentHp, 0, _hpMax);
             if (_onHpChange != null )
            {
                _onHpChange(CurrentHp, HpMax);
            }
           
        }
    }  

    void Awake()
    {
        CharacterManager.Instance.Character = this;
        CurrentHp = HpMax;
    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrentHp -= 1;
        }
    }
}