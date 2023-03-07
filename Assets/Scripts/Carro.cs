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
    public int rota = 0;
    public List<GameObject> Destinos1;
    public List<GameObject> Destinos2;
    public int ponteiro;
     void Start()
    {
        Car = GetComponent<NavMeshAgent>();
        ponteiro = 0;
        rota = Random.Range(1, 3);
        if (rota == 1)
        {
            Destiny = Destinos1[0];
        }
        else
        {
            Destiny = Destinos2[0];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rota == 1)
        {

            //Envia o Carro para direção certa
            Car.SetDestination(Destiny.transform.position);
            //Distancia entre dois pontos
            float distancia = Vector3.Distance(transform.position, Destiny.transform.position);
            if (distancia < 5)
            {

                if (Destinos1[ponteiro].gameObject.tag == "Lento")
                {
                    Car.speed = Random.Range(20, 30);
                }
                else if (Destinos1[ponteiro].gameObject.tag == "Medio")
                {
                    Car.speed = Random.Range(30, 40);
                }
                else if (Destinos1[ponteiro].gameObject.tag == "Rapido")
                {
                    Car.speed = Random.Range(40, 50);
                }

                //Aumenta ponteiro
                ponteiro++;
                //Completou a volta
                if (ponteiro > Destinos1.Count - 1)
                {
                    ponteiro = 0;
                    rota = Random.Range(1, 3);
                }
                Destiny = Destinos1[ponteiro];
            }
        }
            if (rota == 2)
            {

                //Envia o Carro para direção certa
                Car.SetDestination(Destiny.transform.position);
                //Distancia entre dois pontos
                float distancia2 = Vector3.Distance(transform.position, Destiny.transform.position);
                if (distancia2 < 5)
                {

                    if (Destinos2[ponteiro].gameObject.tag == "Lento")
                    {
                        Car.speed = Random.Range(20, 30);
                    }
                    else if (Destinos2[ponteiro].gameObject.tag == "Medio")
                    {
                        Car.speed = Random.Range(30, 40);
                    }
                    else if (Destinos2[ponteiro].gameObject.tag == "Rapido")
                    {
                        Car.speed = Random.Range(40, 50);
                    }

                    //Aumenta ponteiro
                    ponteiro++;
                    //Completou a volta
                    if (ponteiro > Destinos2.Count - 1)
                    {
                        ponteiro = 0;
                        rota = Random.Range(1, 3);
                    }
                    Destiny = Destinos2[ponteiro];
                }
            }
    }
}
