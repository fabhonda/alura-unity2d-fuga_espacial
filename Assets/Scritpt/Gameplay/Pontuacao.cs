using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
    public int Pontos 
    {
        get
        {
            return pontos;
        }
    }
    public MeuEventoPersonalizadoInt aoPontuar;
    private int pontos;

    public void Pontuar()
    {
        pontos++;
        aoPontuar.Invoke(pontos);
    }
}

[System.Serializable]
public class MeuEventoPersonalizadoInt : UnityEvent<int>
{

}
