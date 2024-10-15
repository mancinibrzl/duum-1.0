using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D oRigidbody2D;

    public float velocidadeDoJogador;

    private Vector2 comandosDoTeclado;

    void Start()
    {
        
    }

    void Update()
    {
        MovimentarJogador();
    }

    private void MovimentarJogador()
    {
        comandosDoTeclado = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        Vector3 movimentoHorizontal = transform.up * -comandosDoTeclado.x;
        Vector3 movimentoVertical = transform.right * comandosDoTeclado.y;

        oRigidbody2D.velocity = (movimentoHorizontal + movimentoVertical) * velocidadeDoJogador;
    }

}
