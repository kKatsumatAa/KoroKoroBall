using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PLAYER;

public class CameraMove : MonoBehaviour
{
    public Transform transform;
    public Transform transformP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transformP.position.x, transform.position.y, transformP.position.z);
    }
}
