using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    /*
     * Quellenangabe:
     * https://www.youtube.com/watch?v=YdxYdHidCkE
     * 
     */

    public void restart()
    {
        SceneManager.LoadScene("Level01");
    }
}
