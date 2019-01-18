using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 cameraOffset;
    public Transform player;
    public bool follow = true;
    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            transform.position = player.position + cameraOffset;
        }
    }
}
