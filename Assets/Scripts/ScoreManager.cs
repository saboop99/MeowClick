using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //declaração das variaveis
    public TextMeshProUGUI scoreText;
    private int currentScore = 0;

    //chamando o método scoreUpdate
    private void Start()
    {
        scoreUpdate();
    }

    //criação de um método para adicionar pontos e chamando o método scoreUpdate
    public void AddPoints(int score)
    {
        currentScore += score;
        scoreUpdate();
    }

    //criação do método scoreUpdate, que serve para atualizar a atual pontuação na HUD
    private void scoreUpdate()
    {
        scoreText.text = currentScore.ToString();
    }
}
