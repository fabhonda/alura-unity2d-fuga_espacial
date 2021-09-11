using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicaInstancia : MonoBehaviour
{
    public bool sobrescrever;

    void Start()
    {
        var outrasInstancias = GameObject.FindGameObjectsWithTag(tag);
        foreach(var instancia in outrasInstancias)
        {
            if (instancia != this.gameObject && sobrescrever) GameObject.Destroy(instancia.gameObject);
            else GameObject.Destroy(this.gameObject);
        }
    }

}
