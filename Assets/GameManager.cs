using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int coinCount;
    public int coinALLCount;
    public Text textComponent;
    public Text textComponent2;
    public GameObject coinGameObject;

    public void ChangeScene(string nextscene)
    {
        SceneManager.LoadScene(nextscene);
    }

    public void SceneReset()
    {
        string activSceneName=SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activSceneName);
    }

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);//trueだとフルスクリーン
        Application.targetFrameRate = 60;
        coinCount = 0;
    }

    public void StartCountCoin()
    {
        coinALLCount++;
    }

    public void AddCoinCount()
    {
        coinCount = coinCount + 1;
        Debug.Log("CoinCount:" + coinCount);
        textComponent.text = "CoinCount : " + coinCount;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coinALLCount > 0)
        {
            textComponent2.text = "残りコイン : " + (coinALLCount - coinCount);
        }
    }
}
