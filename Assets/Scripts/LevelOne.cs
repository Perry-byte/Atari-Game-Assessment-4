using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPress()
    {
        Debug.Log("Button clicked");
        if (GameManager.currentGameState == GameManager.GameState.Start)
        {
            GameManager.currentGameState = GameManager.GameState.LevelOne;
            SceneManager.LoadScene(1);
        }
    }
}
