using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    private int Score;
    public Text ScoreText;

    void Start()
    {
        Score = 0;
        SetScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube+"))
        {
             other.gameObject.SetActive(false);
             Score = Score + 1;
             SetScoreText();
        }

        if (other.gameObject.CompareTag("Cube-"))
        {
            other.gameObject.SetActive(false);
            Score = Score - 1;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        ScoreText.text = "Score: " + Score.ToString();
    }

}
