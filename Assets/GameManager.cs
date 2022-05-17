using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
