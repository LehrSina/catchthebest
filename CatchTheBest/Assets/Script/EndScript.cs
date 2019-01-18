using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScript : MonoBehaviour
{
  public void restart()
    {
        SceneManager.LoadScene("Level01");
    }
}
