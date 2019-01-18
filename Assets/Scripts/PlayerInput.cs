using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    public bool isEnabled = true;
    public static float DEFAULT_FORCE = 500f;
    public static string TOUCH_KEY = "space";


    void Start()
    {
        EventManager.StartListening("KegelCollision", OnCollision);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isEnabled)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    EventManager.TriggerEvent("UserTap");
                }
            }
            if (Input.GetKey(TOUCH_KEY))
            {
                EventManager.TriggerEvent("UserTap");
            }
        }
    }

    void OnCollision()
    {
        isEnabled = false;
    }
}


