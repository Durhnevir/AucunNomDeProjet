using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{

    [SerializeField] private GameObject _flockUnitPrefab = null;
    [SerializeField] private int _flockSize = 0;
    [SerializeField] private Vector3 _spawnerBounds;

    public GameObject[] _allUnits { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        GenetareUnits();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenetareUnits()
    {
        _allUnits = new GameObject[_flockSize];

        for (int i = 0; i < _flockSize; i++)
        {
            Vector3 randomVector = Random.insideUnitSphere;
            randomVector = new Vector3(randomVector.x * _spawnerBounds.x, randomVector.y * _spawnerBounds.y, randomVector.z * _spawnerBounds.z);
            Vector3 spawnPosition = transform.position + randomVector;
            Quaternion rotation = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0);
            _allUnits[i] = Instantiate(_flockUnitPrefab, spawnPosition, rotation);
        }
    }
}
