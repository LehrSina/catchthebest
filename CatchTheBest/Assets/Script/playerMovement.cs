using UnityEngine;

public class playerMovement : MonoBehaviour
{
    /*
     * Quellenangabe:
     * https://www.youtube.com/watch?v=sXQI_0ILEW4&t=433s
     * https://www.youtube.com/watch?v=WX3ngzRZuIg 
     * 
     * assets für das gesamte Spiel aus AssetStore
     * https://assetstore.unity.com/packages/3d/environments/urban/low-poly-park-61922
     */

    public float moveSpeed = 8f;
    public Rigidbody rb;

    void Start()
    {
        //moveSpeed = 8f;
 
    }

    void Update()
    {
        //bewegen mit Pfeiltasten
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position.y <= 1.05f)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 250.0f);
            }
        }

        //wenn Player runterfällt = gameover
        if (rb.position.y < -7f)
        {
            FindObjectOfType<GameMaster>().GameOver();
        }
    }
}


    
