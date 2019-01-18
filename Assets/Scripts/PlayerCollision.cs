using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Kegel")
        {
            EventManager.TriggerEvent("KegelCollision");
        }
    }
}
