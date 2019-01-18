using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;



public class GameMaster : MonoBehaviour
{
   public void OnButtonStartGame()
    {
        SceneManager.LoadScene("Level01");
    }
}
