using UnityEngine;

public class collision : MonoBehaviour
{
    /*
     * Quellenangabe:
     * https://www.youtube.com/watch?v=HVB6UVcb3f8&list=PLPV2KyIb3jR53Jce9hP7G5xC4O9AgnOuL&index=5
     * 
    */
    public playerMovement movement;

    private void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "Hinderniss")  
        {
            movement.enabled = false;
            //Destroy(gameObject);
            FindObjectOfType<GameMaster>().GameOver();
        }

    }
}


