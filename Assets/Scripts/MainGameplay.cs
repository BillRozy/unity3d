using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainGameplay : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject rotatingArrow;
    private NavArrowRotate rotator;
    private HashSet<int> downKegelsIds = new HashSet<int>();
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
        EventManager.StartListening("KegelIsDown", OnKegelDown);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void OnTouch(int data)
    {
        if (userCanControl)
        {
            rotatorInstance.rotating = false;
            rb.AddForce(2000 * rotatingArrow.transform.rotation.y, 0, 2000);
        }
        userCanControl = false;
    }

    public void OnKegelCollision(int data)
    {
        playerCam.GetComponent<FollowPlayer>().follow = false;
    }

    private void OnKegelDown(int kegelId)
    {
        if (!downKegelsIds.Contains(kegelId))
        {
            downKegelsIds.Add(kegelId);
            EventManager.TriggerEvent("ScoreUpdate", downKegelsIds.Count);
        }

    }
}
