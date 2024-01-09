using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score = 1;
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
