using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float velocidad = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        var Movimiento_X = Input.GetAxisRaw("Horizontal");

        rb2d.velocity = new Vector2(Movimiento_X * velocidad, 0);
    }
}
