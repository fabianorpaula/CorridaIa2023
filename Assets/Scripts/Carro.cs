using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Carro : MonoBehaviour
{
    //Car Agent
    private NavMeshAgent Car;
    //Destino para segue
    public GameObject Destiny;
     void Start()
    {
        Car = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Car.SetDestination(Destiny.transform.position);
    }
}
