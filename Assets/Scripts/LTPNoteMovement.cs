using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTPNoteMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    private bool isStopped = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.velocity = new Vector3(0, -speed, 0);
    }

    void Update()
    {
        if (isStopped)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
            rb.velocity = new Vector3(0, -speed, 0);
        }
    }

    public void StopNote()
    {
        isStopped = true;
    }

    public void ResumeNote()
    {
        isStopped = false;
    }
}
