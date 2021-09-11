using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PainelRanking : MonoBehaviour
{
    public Ranking ranking;
    public GameObject prefabPos;
    void Start()
    {
        var quantidade = ranking.Quantidade();
        var listaColocados = ranking.GetColocados();
        for(var i=0; i < listaColocados.Count; i++)
        {
            if (i >= 5) break;
            var colocado = GameObject.Instantiate(prefabPos, transform);
            colocado.GetComponent<ItemRanking>().Configurar(i, listaColocados[i].nome, listaColocados[i].pontos);            
        }
    }

}
