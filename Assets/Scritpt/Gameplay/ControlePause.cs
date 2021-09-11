using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePause : MonoBehaviour
{
    public GameObject painelPause;
    [Range(0,1)]
    public float escalaDeTempoNoPause;
    private bool jogoParado;

    void Update()
    {
        if (EstaoTocandoNaTela() && jogoParado) ContinuarJogo();
        else if(!jogoParado) PararJogo();
    }

    private void ContinuarJogo()
    {
        StartCoroutine(EsperarEContinuarJogo());
    }

    private IEnumerator EsperarEContinuarJogo()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        MudarEscalaDeTempo(1);
        painelPause.SetActive(false);
        jogoParado = false;
    }

    private void PararJogo()
    {
        painelPause.SetActive(true);
        MudarEscalaDeTempo(escalaDeTempoNoPause);
        jogoParado = true;
    }

    private bool EstaoTocandoNaTela()
    {
        return Input.touchCount > 0;
    }

    private void MudarEscalaDeTempo(float escala)
    {
        Time.timeScale = escala;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
