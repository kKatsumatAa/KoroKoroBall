using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    public RectTransform rectTransform;
    private float sinNum = 0;
    private float textPosY = 0;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        sinNum = 0;
        textPosY=rectTransform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        sinNum+=0.03f;
        rectTransform.position = new Vector3(gameObject.transform.position.x,
            textPosY + Mathf.Cos(sinNum)*50.0f,
            gameObject.transform.position.z);
    }
}
