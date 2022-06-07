using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dai : MonoBehaviour
{
    public Rigidbody playerRigid;
  

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerRigid = other.GetComponent<Rigidbody>();
            playerRigid.angularVelocity = Vector3.zero;
            playerRigid.velocity = Vector3.zero;
            playerRigid.AddForce(new Vector3(-300, 100, 0));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
