using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //declara��o das variaveis
    public TextMeshProUGUI scoreText;
    private int currentScore = 0;

    //chamando o m�todo scoreUpdate
    private void Start()
    {
        scoreUpdate();
    }

    //cria��o de um m�todo para adicionar pontos e chamando o m�todo scoreUpdate
    public void AddPoints(int score)
    {
        currentScore += score;
        scoreUpdate();
    }

    //cria��o do m�todo scoreUpdate, que serve para atualizar a atual pontua��o na HUD
    private void scoreUpdate()
    {
        scoreText.text = currentScore.ToString();
    }
}
