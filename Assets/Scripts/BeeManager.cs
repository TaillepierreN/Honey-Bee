using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BeeManager : MonoBehaviour
{
    [SerializeField] Transform beeSpawnPoint;
    [SerializeField] Transform beeReturnPoint;
    NavMeshAgent _beeAgent;
    Vector3 _destination;
    bool pollenized;
    float distanceToHive;
    void Start()
    {
        _beeAgent = GetComponent<NavMeshAgent>();
        beeSpawnPoint = GameObject.Find("BeeSpawnPoint").transform;
        beeReturnPoint = GameObject.Find("BeeReturnPoint").transform;
        pollenized = false;
    }
    public void GoHome()
    {
        _destination = _beeAgent.destination;
        _beeAgent.SetDestination(beeReturnPoint.position);
        pollenized = true;
    }
    public void GoWork()
    {
        if(pollenized)
        {
        _beeAgent.SetDestination(_destination);
        pollenized = false;
        }
    }
    void Update()
    {
        distanceToHive = Vector3.Distance(gameObject.transform.position,beeReturnPoint.position);
        if(distanceToHive < 1f) GoWork();
    }
}
