using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField]
    private GameObject reticlePrefab;
    private float rotationSpeed = 50.0f;
    private Vector3 vector3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.isPlaying)
        {
            vector3 = new Vector3(0, 1, 0);
            transform.Rotate(rotationSpeed * Time.deltaTime * vector3);
        }
    }
}
