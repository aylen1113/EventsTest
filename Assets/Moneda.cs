using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{ 
    public delegate void MonedaEvent(); 
    public static MonedaEvent monedaEvent;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        { 
        monedaEvent?.Invoke();
        Destroy(this.gameObject);
        }

    }

}
