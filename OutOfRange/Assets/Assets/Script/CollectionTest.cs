using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionTest : MonoBehaviour
{
    #region Field
    [SerializeField] private int[] _intTab;
    private List<int> _intList = null;
    private Dictionary<string, GameObject> _dic = null;
    #endregion Field

    private void Start()
    {
        _intList = new List<int>();
        _dic = new Dictionary<string, GameObject>();

        _intList.Add(1);
        _intList.Insert(3, 1);
        _intList.RemoveAt(2);





        _intTab[2] = 10;

        for (int i = 0; i < _intList.Count; i++)
        {
            Debug.Log(_intList[i]);
        }

    }
}
