using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject _flower1;
    [SerializeField] GameObject _flower2;
    [SerializeField] Transform beeSpawnPoint;
    [SerializeField] GameObject _bees;
    public List<GameObject> _spawnedFlowers;
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
        SpawnBees(_nbrBees);
    }

    private void SpawnFlowerAtRandom(int num, int type)
    {
        for (int i = 0; i < num; i++)
        {
            RandomCoordinate();
            switch (type)
            {
                case 1:
                    var flowy1 = Instantiate(_flower1, spawnCoord, Quaternion.identity);
                    _spawnedFlowers.Add(flowy1);
                    break;
                case 2:
                    var flowy2 = Instantiate(_flower2, spawnCoord, Quaternion.identity);
                    _spawnedFlowers.Add(flowy2);
                    break;
            }

        }
    }
    private Vector3 RandomCoordinate()
    {
        spawnX = Random.Range(-6.80f, 15.8f);
        spawnY = 0.003f;
        spawnZ = Random.Range(-4.70f, 18f);
        return spawnCoord = new Vector3(spawnX, spawnY, spawnZ);
    }
    private void SpawnBees(int nbrBees)
    {
        for(int i = 0; i < nbrBees; i++)
        {
            var spawnedBee = Instantiate(_bees, beeSpawnPoint.position, Quaternion.identity);
            var randFlowerIndex = Random.Range(0,_spawnedFlowers.Count);
            spawnedBee.GetComponent<NavMeshAgent>().SetDestination(_spawnedFlowers[randFlowerIndex].transform.position);

        }
    }
    void Update()
    {

    }

}
