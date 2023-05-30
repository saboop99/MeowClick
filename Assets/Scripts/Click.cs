using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    //declara��o de vari�veis
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
        //condicional caso eu clique com o bot�o esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        {
            //tocando o a�dio na posi��o atual do gato, para poder tocar ap�s destruir
            AudioSource.PlayClipAtPoint(Meow, transform.position);
            //adicionando pontos
            scoreManager.AddPoints(cats);
            //destruindo o gato
            Destroy(gameObject);

        }
    }
}
