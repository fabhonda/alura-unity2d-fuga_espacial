using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReservaInimigo : MonoBehaviour
{

    public GameObject prefab;
    public int quantidade;
    private Stack<GameObject> reservaInimigos;

    void Start()
    {
        reservaInimigos = new Stack<GameObject>();
        criarTodosInimigos();
    }

    private void criarTodosInimigos()
    {
        for (var i = 0; i < quantidade; i++)
        {
            var inimigo = GameObject.Instantiate(prefab,transform);
            var objetoReserva = inimigo.GetComponent<ObjetoReservaInimigo>();
            objetoReserva.SetReserva(this);
            inimigo.SetActive(false);
            reservaInimigos.Push(inimigo);
        }
    }

    public GameObject PegarInimigo()
    {
        var inimigo = reservaInimigos.Pop();
        inimigo.SetActive(true);
        return inimigo;
    }

    public void DevolverInimigo(GameObject inimigo)
    {
        inimigo.SetActive(false);
        reservaInimigos.Push(inimigo);
    }

    public bool TemInimigo()
    {
        return reservaInimigos.Count > 0;
    }

}
