using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform playerTransform;
    Transform CameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraTransform.transform.position.Set(
            transform.position.x,
            CameraTransform.transform.position.y, 
            transform.position.z);
    }
}
