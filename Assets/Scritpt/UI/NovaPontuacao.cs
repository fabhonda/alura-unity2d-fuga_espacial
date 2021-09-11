using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{

    public TextoDinamico textoPontuacao;
    public TextoDinamico textoNome;
    public Ranking ranking;
    private string id;
    private Pontuacao pontuacao;

    void Start()
    {
        int totalPontos = GetPontuacao();
        string nomePessoa = GetNome();
        textoPontuacao.AtualizarTexto(totalPontos);
        textoNome.AtualizarTexto(nomePessoa);
        id = ranking.AdicionarPontuacao(totalPontos, nomePessoa);
    }

    private string GetNome()
    {
        if (PlayerPrefs.HasKey("UltimoNome")) return PlayerPrefs.GetString("UltimoNome");
        return "Nome";
    }

    private int GetPontuacao()
    {
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        var totalPontos = -1;
        if (pontuacao != null) totalPontos = pontuacao.Pontos;
        return totalPontos;
    }

    public void AlterarNome(string nome)
    {
        ranking.AlterarNome(nome,id);
        PlayerPrefs.SetString("UltimoNome",nome);
    }

}
