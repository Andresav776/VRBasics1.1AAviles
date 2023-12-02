using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private AudioSource ballAudio;
    public AudioClip bounce;
    private Rigidbody rb;
    float ballMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        ballAudio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        ballMagnitude = rb.velocity.magnitude / 2;
        Debug.Log(ballMagnitude);
        if (ballMagnitude > 1)
            {
                ballMagnitude = 1;
            }
        ballAudio.PlayOneShot(bounce, ballMagnitude);
    }
}
