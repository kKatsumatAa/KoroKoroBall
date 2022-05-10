using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public Transform transform;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
