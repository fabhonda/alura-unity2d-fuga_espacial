using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuavel : MonoBehaviour
{
    private Pontuacao pontuacao;

    public void Pontuar()
    {
        pontuacao.Pontuar();
    }

    public void SetPontuacao(Pontuacao pontuacao)
    {
        this.pontuacao = pontuacao;
    }
}
