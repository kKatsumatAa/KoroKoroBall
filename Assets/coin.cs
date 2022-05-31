using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public Transform transform;
    //public Rigidbody rigidbody;
    public GameObject otherGameObject;
    private GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);

            if(gameObject.tag =="key")
            {
                Destroy(gameObject);
                Destroy(otherGameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();

        
        //ゲームオブジェクトを探して変数に控えておく
        GameObject managerObject = GameObject.Find("GameManager");
        //
        gameManager = managerObject.GetComponent<GameManager>();

        //コイン総数カウント
        gameManager.StartCountCoin();
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
