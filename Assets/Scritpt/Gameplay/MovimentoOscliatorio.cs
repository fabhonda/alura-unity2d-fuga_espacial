using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoOscliatorio : MonoBehaviour
{
    public float amplitude;
    public float velocidade;
    private Vector3 posicaoInicial;
    private float angulo;

    private void Awake()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        angulo += velocidade;
        var variacao = Mathf.Sin(angulo);
        transform.position = posicaoInicial + (amplitude * variacao * Vector3.up);
    }
}
