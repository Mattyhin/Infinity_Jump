using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public float startPos;
    public TextMeshProUGUI scoreText;

    public GameObject endMenu;
    public TextMeshProUGUI loseScore;
    public TextMeshProUGUI loseMaxScore;
    
    void Start()
    {
        startPos = transform.position.y;
        score = (int) (transform.position.y - startPos);
    }
    
    void Update()
    {
        if ((int)(transform.position.y - startPos) > score)
        {
            score = (int) (transform.position.y - startPos);
            scoreText.text = "Счёт: " + score.ToString();
        }
    }

    private void OnDestroy()
    {
        if (score > PlayerPrefs.GetInt("maxScore", 0))
        {
           PlayerPrefs.SetInt("maxScore", score); 
        }
        
        endMenu.SetActive(true);
        loseScore.text = "Текущий счёт:" + score.ToString();
        int max = PlayerPrefs.GetInt("maxScore", 0);
        loseMaxScore.text = "Лучший счёт:" + max.ToString();
    }
}
