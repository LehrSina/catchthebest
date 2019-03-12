using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    /*
    * Quellenangabe:
    * https://www.youtube.com/watch?v=HVB6UVcb3f8&list=PLPV2KyIb3jR53Jce9hP7G5xC4O9AgnOuL&index=5
    * 
    */

    public Transform player;
    public Vector3 offset;  
    
    void Update()
    {
        transform.position = player.position + offset;
    }
}
 