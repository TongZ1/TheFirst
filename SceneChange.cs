using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private GameObject Stone;
    private void Start()
    {
        Stone = GameObject.FindGameObjectWithTag("Mark");
        Data.DestroyNumber = 0;
        Data.ShootNumber = 0;
        Data.ShootBingoNumber = 0;
    }

    public void turnBack()
    {
        SceneManager.LoadScene("MainUI");
        Cursor.lockState = CursorLockMode.None;


    }
    public void QuitGame()
    {
        Application.Quit();

    }
    public void EnterGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
