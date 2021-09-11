using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private static string NOME_DO_ARQUIVO = "Ranking.json";
    public List<Colocado> listaColocados;
    private string caminhoArquivo;

    void Awake()
    {
        //C:/Users/fabri/AppData/LocalLow/DefaultCompany/projeto
        caminhoArquivo = Path.Combine(Application.persistentDataPath, NOME_DO_ARQUIVO);
        if (File.Exists(caminhoArquivo)){
            var textoJson = File.ReadAllText(caminhoArquivo);
            JsonUtility.FromJsonOverwrite(textoJson, this);
        } else listaColocados = new List<Colocado>();

    }

    public string AdicionarPontuacao(int pontos, string nome)
    {
        var id = Guid.NewGuid().ToString();
        var novoColocado = new Colocado(nome, pontos, id);
        this.listaColocados.Add(novoColocado);
        listaColocados.Sort();
        SalvarRanking();
        return id;
    }

    public void AlterarNome(string novoNome, string id)
    {
        foreach(var item in listaColocados)
        {
            if(item.id == id)
            {
                item.nome = novoNome;
                break;
            }
        }
        SalvarRanking();
    }

    public int Quantidade()
    {
        return listaColocados.Count;
    }

    public ReadOnlyCollection<Colocado> GetColocados()
    {
        return this.listaColocados.AsReadOnly();
    }

    private void SalvarRanking()
    {
        var textoJson = JsonUtility.ToJson(this,true);
        File.WriteAllText(caminhoArquivo, textoJson);
        
    }
}

[System.Serializable]
public class Colocado : IComparable
{
    public string nome;
    public int pontos;
    public string id;

    public Colocado(string nome,int pontos, string id)
    {
        this.nome = nome;
        this.pontos = pontos;
        this.id = id;
    }

    public int CompareTo(object obj)
    {
        var outroObjeto = obj as Colocado;
        return outroObjeto.pontos.CompareTo(pontos);
    }
}
