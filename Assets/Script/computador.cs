using UnityEngine;

public class computador : MonoBehaviour
{
    public Transform bolinha; // Referência ao transform da bolinha
    public float velocidade = 5f; // Velocidade de movimento da raquete do computador

    private Rigidbody2D rbComp; // Referência ao Rigidbody2D da raquete do computador

    void Start()
    {
        rbComp = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D do objeto atual (raquete do computador)
    }

    void FixedUpdate()
    {
        // Move a raquete do computador em direção à posição da bolinha no eixo Y, multiplicada pela velocidade
        rbComp.linearVelocity = new Vector2(0, (bolinha.position.y - transform.position.y) * velocidade); 
    }
}
