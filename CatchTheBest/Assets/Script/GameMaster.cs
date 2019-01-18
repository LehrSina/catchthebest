using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;



public class GameMaster : MonoBehaviour
{
    bool gameHasEnded = false; 

   //GameOver wenn player runterfällt/gegen Gegenstand läuft
    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            SceneManager.LoadScene("GameOver"); 
        }
    }

   //Start Button     
   public void OnButtonStartGame()
    {
        SceneManager.LoadScene("Level01");
    }
}
