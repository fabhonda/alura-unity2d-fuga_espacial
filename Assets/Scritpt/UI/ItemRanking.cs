using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemRanking : MonoBehaviour
{
    public Text textoRank;
    public Text textoNome;
    public Text textoPontos;

    public void Configurar(int colocacao, string nome, int pontuacao)
    {
        textoRank.text = colocacao.ToString();
        textoNome.text = nome;
        textoPontos.text = pontuacao.ToString();
    }
}
