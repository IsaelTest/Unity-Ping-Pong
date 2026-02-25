using UnityEngine;
using TMPro;  // Mude de UnityEngine.UI para TMPro


public class gameManager : MonoBehaviour
{
    public int pontuacao1; // Variável para armazenar a pontuação do jogador 1
    public int pontuacao2; // Variável para armazenar a pontuação do jogador 2
    public TMP_Text pontos_player1; // Referência ao componente Text para exibir a pontuação do jogador 1     
    public TMP_Text pontos_player2; // Referência ao componente Text para exibir a pontuação do jogador 2

    void Start()
    {
        pontuacao1 = 0; // Inicializa a pontuação do jogador 1 como 0
        pontuacao2 = 0; // Inicializa a pontuação do jogador 2 como 0
    }

    void Update()
    {
        // Atualiza o texto dos componentes Text para exibir as pontuações atuais dos jogadores
        pontos_player1.text = pontuacao1.ToString(); // Converte a pontuação do jogador 1 para string e exibe no componente Text
        pontos_player2.text = pontuacao2.ToString(); // Converte a pontuação do jogador 2 para string e exibe no componente Text
    }
}
