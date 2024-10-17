using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D oRigidbody2D;

    public float velocidadeDoJogador;
    public float sensibilidadeDoMouse;

    private Vector2 comandosDoTeclado;
    private Vector2 movimentoDoMouse;

    void Start()
    {
        
    }

    void Update()
    {
        MovimentarJogador();
        GirarCamera();
    }

    private void MovimentarJogador()
    {
        comandosDoTeclado = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        Vector3 movimentoHorizontal = transform.up * -comandosDoTeclado.x;
        Vector3 movimentoVertical = transform.right * comandosDoTeclado.y;

        oRigidbody2D.velocity = (movimentoHorizontal + movimentoVertical) * velocidadeDoJogador;
    }

    private void GirarCamera()
    {
        movimentoDoMouse = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y") * sensibilidadeDoMouse);

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - movimentoDoMouse.x);
    }

}
