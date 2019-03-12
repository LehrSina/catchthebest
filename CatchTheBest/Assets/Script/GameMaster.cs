using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameMaster : MonoBehaviour
{
    /*
     * Quellenangabe:
     * https://www.youtube.com/watch?v=YdxYdHidCkE
     * https://www.youtube.com/watch?v=VbZ9_C4-Qbo&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6&index=9
     */

    bool gameHasEnded = false; 

   //gameover wenn Player runterfällt (und gegen Gegenstand läuft)
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
