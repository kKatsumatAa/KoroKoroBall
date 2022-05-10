using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PLAYER
{
    public class Player : MonoBehaviour
    {
        public Rigidbody rigidbody;
        public Transform transform;
        public Vector3 respown = new Vector3(-23.7f, 2.5f, -28.4f);

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.y < -5)
            {
                Debug.Log("GameOver!!!");
                transform.position = new Vector3(-23.7f, 2.5f, -28.4f);
                rigidbody.velocity = Vector3.zero;
                rigidbody.angularVelocity = Vector3.zero;
            }
        }
    }
}
