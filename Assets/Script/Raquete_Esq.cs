using UnityEngine;
using UnityEngine.InputSystem;

public class Raquete_Esq : MonoBehaviour
{

    public Vector3 minhaPosicao;
    public float meuY;
    public float velocidade = 5f;
    public float meuLimite = 3.0f;

    void Start()
    {
        minhaPosicao = transform.position;
    }

    void Update()
    {
        float deltaVelocidade = velocidade * Time.deltaTime;
        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;
        Keyboard keyboard = Keyboard.current;

        if (keyboard.qKey.isPressed)
        {
            meuY = meuY + deltaVelocidade;
        }
        Gamepad gamepad = Gamepad.current;

        if (gamepad != null)
        {
            // Usando o stick analógico
            Vector2 stickValue = gamepad.leftStick.ReadValue();
            meuY += stickValue.y * deltaVelocidade;

            // OU usando botões específicos (descomente se preferir)
            if (gamepad.buttonSouth.isPressed) // Botão A (Xbox) / X (PlayStation)
            {
                meuY += deltaVelocidade;
            }
            if (gamepad.buttonEast.isPressed) // Botão B (Xbox) / Circle (PlayStation)
            {
                meuY -= deltaVelocidade;
            }
        }
        if (keyboard.zKey.isPressed)
        {
            meuY = meuY - deltaVelocidade;
        }

        // Verifica se a raquete está tentando passar do limite inferior da tela
        if (meuY < -meuLimite)
        {
            // Se sim, fixa a posição no limite inferior
            meuY = -meuLimite;
        }

        // Verifica se a raquete está tentando passar do limite superior da tela
        if (meuY > meuLimite)
        {
            // Se sim, fixa a posição no limite superior
            meuY = meuLimite;
        }
    }
}
