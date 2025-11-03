using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public Rigidbody rb;
    
    private void Start()
    {
        rb.useGravity = false;
    }

     private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collieded with Player");

            rb.useGravity = true;
        }
    }
}

