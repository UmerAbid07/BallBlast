using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    PlayerMove playerInfo;
    public GameObject pauseUI;
    public GameObject reStart;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        playerInfo = GameObject.Find("Player").GetComponent<PlayerMove>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInfo.gameOver)
        {
            reStart.SetActive(true);
            Time.timeScale = 0;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            gamePause();
            pauseUI.SetActive(true);
        }
        
    }
    public void Reset()
    {
        SceneManager.LoadScene("Prototype 3");
    }
    void gamePause()
    {
        Time.timeScale = 0;
    }
    public void resume()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
    }
    public void exitGame()
    {
        Application.Quit();
    }
   

}
