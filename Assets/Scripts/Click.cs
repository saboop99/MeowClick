using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    //declaração de variáveis
    public int cats = 1;
    private ScoreManager scoreManager;
    public AudioClip Meow;

    private void Start()
    {
        //Achando o ScoreManager para poder adicionar os pontos pra HUD
        scoreManager = FindObjectOfType<ScoreManager>();
        //pegando o componente AudioSource do objeto
        GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        //condicional caso eu clique com o botão esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        {
            //tocando o aúdio na posição atual do gato, para poder tocar após destruir
            AudioSource.PlayClipAtPoint(Meow, transform.position);
            //adicionando pontos
            scoreManager.AddPoints(cats);
            //destruindo o gato
            Destroy(gameObject);

        }
    }
}
