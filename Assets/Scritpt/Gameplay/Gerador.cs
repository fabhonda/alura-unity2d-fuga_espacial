using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gerador : MonoBehaviour
{
    public Transform alvo;
    public Pontuacao pontuacao;
    public ReservaInimigo reservaInimigo;
    [SerializeField]
    private float tempo;
    [SerializeField]
    private Rect area;

    private void Start()
    {
        InvokeRepeating("Instanciar", 0f, tempo);
    }

    private void Instanciar()
    {
        if (reservaInimigo.TemInimigo())
        {
            var inimigo = reservaInimigo.PegarInimigo();
            this.DefinirPosicaoInimigo(inimigo);
            inimigo.GetComponent<Seguir>().SetAlvo(alvo);
            inimigo.GetComponent<Pontuavel>().SetPontuacao(pontuacao);
        }

    }

    private void DefinirPosicaoInimigo(GameObject inimigo)
    {
        var posicaoAleatoria = new Vector2(Random.Range(area.x, area.x + area.width), Random.Range(area.y, area.y + area.height));
        var posicaoInimigo = (Vector2)this.transform.position + posicaoAleatoria;
        inimigo.transform.position = posicaoInimigo;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(100,0,100);
        var posicao = area.position + (Vector2)transform.position + area.size/2;
        Gizmos.DrawWireCube(posicao,area.size);
    }
}
