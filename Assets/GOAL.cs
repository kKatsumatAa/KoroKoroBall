using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOAL : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audiosource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("GOAL!!!");

            clearText.SetActive(true);
            nextButton.SetActive(true);
            audiosource.Play();
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
