using UnityEngine;

public class collision : MonoBehaviour
{
    public playerMovement movement;

    private void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "Hinderniss")  
        {
            //movement.enabled = false;
            Destroy(gameObject);
        }

    }
}


