using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject _flower1;
    [SerializeField] GameObject _flower2;
    [SerializeField] GameObject _bees;
    [SerializeField] int _nbrFlower;
    [SerializeField] int _nbrBees;
    float spawnX;
    float spawnY;
    float spawnZ;
    Vector3 spawnCoord;
    // Start is called before the first frame update
    void Start()
    {
        SpawnFlowerAtRandom(_nbrFlower, 1);
        SpawnFlowerAtRandom(_nbrFlower, 2);
    }

    private void SpawnFlowerAtRandom(int num, int type)
    {
        for (int i = 0; i < num; i++)
        {
            RandomCoordinate();
            var flowy = Instantiate(_flower1, spawnCoord, Quaternion.identity);
        }
    }
    private Vector3 RandomCoordinate()
    {
        spawnX = Random.Range(-6.80f, 15.8f);
        spawnY = 0.003f;
        spawnZ = Random.Range(-4.70f, 18f);
        return spawnCoord = new Vector3(spawnX, spawnY, spawnZ);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
