using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    /*
     * Quellenangabe:
     * https://www.youtube.com/watch?v=CLSiRf_OrBk
     * 
     */
   
    public GameObject pickupEffect;
    public float duration = 4f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        //Effekt anwenden
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        playerMovement speed = player.GetComponent<playerMovement>();
        speed.moveSpeed -= 10f;

        //Warte bestimmte Zeit
        yield return new WaitForSeconds(duration);
        //Effekt rueckgaengig machen
        speed.moveSpeed += 10f;

        Destroy(gameObject);
        Debug.Log("Pickup the powerup");
    }
}