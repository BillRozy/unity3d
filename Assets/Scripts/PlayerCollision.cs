using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Collision!");
            rb.AddForce(0, 20000 * Time.deltaTime, 0);
            movement.isEnabled = false;
        }
    }
}
