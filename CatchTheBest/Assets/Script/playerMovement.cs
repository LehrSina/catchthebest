using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
        moveSpeed = 8f;
    }

    void Update()
    {
        //moveing with Arrow Keys
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position.y <= 1.05f)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 250.0f);
            }
        }
    }
}




    
