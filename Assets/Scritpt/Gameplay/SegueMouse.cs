using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueMouse : MonoBehaviour
{
    void Update()
    {
        var posicao = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = posicao;
    }
}
