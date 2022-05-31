using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorController : MonoBehaviour
{
    private Transform transform;
    private const float rotSpeed = 0.002f;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        transform.rotation=new Quaternion(0,0,0, transform.rotation.w);
        transform.rotation=new Quaternion(0,0,90/180*3.14f, transform.rotation.w);
        //transform.rotation = new Quaternion(0, 0, 0, transform.rotation.w);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Sample3")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.rotation = new Quaternion(transform.rotation.x + rotSpeed, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.rotation = new Quaternion(transform.rotation.x - rotSpeed, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z + rotSpeed, transform.rotation.w);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z - rotSpeed, transform.rotation.w);
            }
            transform.rotation = new Quaternion(transform.rotation.x + rotSpeed/10.0f, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            //if(transform.rotation.x >= 45.0f / 180.0f * 3.14f)
            //{
            //    transform.rotation.x = 45.0f
            //}
        }
    }
}
