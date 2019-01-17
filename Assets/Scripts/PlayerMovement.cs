using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public bool isEnabled = true;
    public PlayerMovementListener listener;
    public static float DEFAULT_FORCE = 500f;
    public static string FORWARD_KEY = "w";
    public static string LEFT_KEY = "a";
    public static string RIGHT_KEY = "d";


    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isEnabled)
        {
            if (Input.GetKey(FORWARD_KEY))
            {
                listener.OnForward();
            }
            if (Input.GetKey(LEFT_KEY))
            {
                listener.OnLeft();
            }
            if (Input.GetKey(RIGHT_KEY))
            {
                listener.OnRight();
            }
        }
    }

    public interface PlayerMovementListener
    {
        void OnForward();
        void OnLeft();
        void OnRight();

    }
}


