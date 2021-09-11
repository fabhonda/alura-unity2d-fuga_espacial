using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoReservaInimigo : MonoBehaviour
{
    private ReservaInimigo minhaReserva;

    public void Devolver()
    {
        minhaReserva.DevolverInimigo(gameObject);
    }

    public void SetReserva(ReservaInimigo reserva)
    {
        minhaReserva = reserva;
    }
}
