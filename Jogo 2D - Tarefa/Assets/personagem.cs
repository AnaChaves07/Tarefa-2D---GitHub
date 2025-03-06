using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    Vector2 direcao;   // direção de movimento
    public float velocidade = 5f;  // velocidade de movimento

    // Start é chamado antes do primeiro frame
    void Start()
    {
        // Se necessário, adicione inicialização aqui
    }

    // Update é chamado a cada quadro
    void Update()
    {
        // Verifica a tecla pressionada para mover para a esquerda
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direcao.x = -1;
            // Aqui você pode adicionar o movimento do objeto
            transform.Translate(direcao * velocidade * Time.deltaTime);
        }
        // Verifica a tecla pressionada para mover para a direita
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direcao.x = 1;
            // Aqui você pode adicionar o movimento do objeto
            transform.Translate(direcao * velocidade * Time.deltaTime);
        }
        // Verifica a tecla pressionada para mover para cima
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direcao.y = 1;
            // Aqui você pode adicionar o movimento do objeto
            transform.Translate(direcao * velocidade * Time.deltaTime);
        }
        // Verifica a tecla pressionada para mover para baixo
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direcao.y = -1;
            // Aqui você pode adicionar o movimento do objeto
            transform.Translate(direcao * velocidade * Time.deltaTime);
        }
    }
}
