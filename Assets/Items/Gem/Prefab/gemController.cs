using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemController : MonoBehaviour
{
    private void OnDestroy(){
        GameObject scoreCounter = GameObject.Find("ScoreGem");
        Score score = scoreCounter.GetComponent<Score>();
        score.gems++;
    }
}