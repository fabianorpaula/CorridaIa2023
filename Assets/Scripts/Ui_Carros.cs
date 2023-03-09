using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class Ui_Carros : MonoBehaviour
{
    public Carro meuCarro;
    public TMP_Text nomeT;
    public TMP_Text voltaT;
    public TMP_Text posT;
    public TMP_Text velT;
    
    void Update()
    {
        nomeT.text = "Nome: "+meuCarro.name;
        voltaT.text = "Voltar: "+meuCarro.volta.ToString();
        velT.text = meuCarro.GetComponent<NavMeshAgent>().speed.ToString()+" Km/h";
        posT.text = "Pos: "+meuCarro.pos.ToString();
    }
}
