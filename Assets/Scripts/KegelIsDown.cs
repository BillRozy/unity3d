using UnityEngine;


public class KegelIsDown : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "KegelDownDetector")
        {
            EventManager.TriggerEvent("KegelIsDown", collisionInfo.collider.GetInstanceID());
        }
    }
}
