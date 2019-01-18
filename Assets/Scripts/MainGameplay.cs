using UnityEngine;

public class MainGameplay : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject rotatingArrow;
    private NavArrowRotate rotator;
    public NavArrowRotate rotatorInstance {
        get
        {
            if (!rotator)
            {
                rotator = rotatingArrow.GetComponent<NavArrowRotate>();

                if (!rotator)
                {
                    Debug.LogError("Bad news");
                }
            }

            return rotator;
        }
    }
    public Camera playerCam;
    private bool userCanControl = true;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening("UserTap", OnTouch);
        EventManager.StartListening("KegelCollision", OnKegelCollision);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void OnTouch()
    {
        if (userCanControl)
        {
            rotatorInstance.rotating = false;
            rb.AddForce(0, 0, 70000 * Time.deltaTime);
        }
        userCanControl = false;
    }

    public void OnKegelCollision()
    {
        playerCam.GetComponent<FollowPlayer>().follow = false;
    }
}
