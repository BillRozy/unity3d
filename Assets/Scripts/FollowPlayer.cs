using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 cameraOffset;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + cameraOffset;
    }
}
