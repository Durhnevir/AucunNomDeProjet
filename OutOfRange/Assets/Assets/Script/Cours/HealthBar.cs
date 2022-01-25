using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    

    [SerializeField] private RectTransform _bar = null;
    private Vector3 _startPosition = Vector3.zero;
    private Vector3 _endPosition = Vector3.zero;
    private float _t = 0.5f;

    private void Start()
    {
        if (CharacterManager.Instance.Character != null)
        {
            CharacterManager.Instance.Character.OnHpChange += UpdateBar;
        }

        _startPosition.x = -_bar.rect.width;

    }

    void UpdateBar(float currentHp, int hpMax)
    {
        _t = currentHp / (float)hpMax;
        _bar.localPosition = Vector3.Lerp(_startPosition, _endPosition, _t);
    }
}
