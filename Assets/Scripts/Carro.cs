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
    public List<GameObject> Destinos;
    public int ponteiro;
     void Start()
    {
        Car = GetComponent<NavMeshAgent>();
        ponteiro = 0;
        Destiny = Destinos[0];
    }

    // Update is called once per frame
    void Update()
    {
        //Envia o Carro para direção certa
        Car.SetDestination(Destiny.transform.position);
        //Distancia entre dois pontos
        float distancia = Vector3.Distance(transform.position, Destiny.transform.position);
        if (distancia < 5)
        {

            if(Destinos[ponteiro ].gameObject.tag == "Lento")
            {
                Car.speed = Random.Range(20, 30);
            }
            else if (Destinos[ponteiro].gameObject.tag == "Medio")
            {
                Car.speed = Random.Range(30, 40);
            }
            else if (Destinos[ponteiro].gameObject.tag == "Rapido")
            {
                Car.speed = Random.Range(40, 50);
            }

            //Aumenta ponteiro
            ponteiro++;
            if(ponteiro > Destinos.Count-1) { ponteiro = 0; }
            Destiny = Destinos[ponteiro];
        }
    }
}
