using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameScoree : MonoBehaviour
{
    public TextMeshProUGUI EndScore;

    // Update is called once per frame
    void Update()
    {
        EndScore.text = Score.score.ToString();

    }
}
