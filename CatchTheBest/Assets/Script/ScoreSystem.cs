using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    private int Score;
    public int Leben = 1;
    public float playerTime;

    public Text ScoreText;
    public Text PlayerLiveText;
    private Slider playerTimeBar;

    private Vector3 startposition = new Vector3(0, 1, -17);

    private bool playerDeath = false;

    void Start()
    {
        Score = 0;
        SetScoreText();

        PlayerLiveText = GameObject.Find("PlayerLives").GetComponent<Text>();
        PlayerLiveText.text = Leben.ToString();

        playerTimeBar = GameObject.Find("PlayerTimeBar").GetComponent<Slider>();
        playerTimeBar.value = Mathf.Round(playerTime);
    }

    void Update()
    {
        if (!playerDeath)
        {
            playerTime -= Time.deltaTime;
            if(playerTime > 0)
            {
                playerTimeBar.value = Mathf.Round(playerTime);
            }
            else
            {
                PlayerDeath();
            }
        }
    }

    //Score
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


    void PlayerDeath()
    {
        playerDeath = true;
        if (Leben == 0)
        {
            Destroy(GameObject.Find("Level01")); 
            SceneManager.LoadScene("GameOver");
       
        }
        else { 

            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<playerMovement>().enabled = false;
            this.transform.position = startposition;
            Leben -= 1; 
            PlayerLiveText.text = Leben.ToString();
            StartCoroutine(SpawnPlayer()); 
         }
    }

    //Player wird wieder sichtbar und kann bewegt werden
    IEnumerator SpawnPlayer()
    {
        yield return new WaitForSeconds(3);
        playerTime = 10;
        playerDeath = false;
        this.GetComponent<MeshRenderer>().enabled = true;
        this.GetComponent<playerMovement>().enabled = true;
    }
}
