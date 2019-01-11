using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Hinderniss")
        {
            Destroy(gameObject);
        }

    }
}


