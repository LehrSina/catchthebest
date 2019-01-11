using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    private void OnTriggerEnter(Collider other)
    {
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
    }

}
