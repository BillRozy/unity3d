using UnityEngine;

public class PlayerBehaviour : MonoBehaviour, PlayerMovement.PlayerMovementListener
{
    public Rigidbody rb;
    public PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        pm.listener = this;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void OnForward()
    {
        rb.AddForce(0, 0, PlayerMovement.DEFAULT_FORCE * Time.deltaTime);
    }

    public void OnLeft()
    {
        rb.AddForce(-PlayerMovement.DEFAULT_FORCE * Time.deltaTime, 0, 0);
    }

    public void OnRight()
    {
        rb.AddForce(PlayerMovement.DEFAULT_FORCE * Time.deltaTime, 0, 0);
    }
}
