using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public Transform transform;
    //public Rigidbody rigidbody;
    public GameObject otherGameObject;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5 && gameObject.tag=="key")
        {
            Destroy(gameObject);
            Destroy(otherGameObject);
        }
    }
}
