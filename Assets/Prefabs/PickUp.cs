using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{

    public Text puntajeTxt;

    int puntaje;
    void  OnTriggerEnter(Collider col)
    {
        puntaje += 1;
        puntajeTxt.text = puntaje.ToString();

        if (col.gameObject.CompareTag("food"))
        {
           
            Destroy(col.gameObject);
        }
    }
}