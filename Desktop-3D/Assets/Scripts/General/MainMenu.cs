using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game 1");
    }
        public void Multi()
    {
        SceneManager.LoadScene("Multi");
    }

    public void Enemy()
    {
        SceneManager.LoadScene("Enemy");
    }

    public void Shoot()
    {
        SceneManager.LoadScene("shooting");
    }
    public void Minue()
    {
        SceneManager.LoadScene("L1");
    }

    public void QuitGame(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
