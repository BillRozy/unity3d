using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavArrowRotate : MonoBehaviour
{
    public float maxAngle = 0.35f;
    public float rotateSpeed = 100f;
    private bool rotateRight = true;
    public bool rotating = true;
    private Vector3 pivot;
    // Start is called before the first frame update
    void Start()
    {
        pivot = transform.position - new Vector3(0, 0, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (rotating)
        {
            float newY = rotateRight ? rotateSpeed : -rotateSpeed;
            transform.RotateAround(
                pivot,
                transform.up,
                newY * Time.deltaTime
            );
            if (rotateRight && transform.rotation.y > maxAngle)
            {
                rotateRight = false;
            }
            if (!rotateRight && transform.rotation.y < -maxAngle)
            {
                rotateRight = true;
            }
        }
    }
}
