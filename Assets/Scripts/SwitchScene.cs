using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    //Switch to Game Scene from Home Menu
  public void StartGame()
    {
        SceneManager.LoadScene("Prototype 2");
    }

    //End the Game
  public void EndGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    //Switch to Game Scene from Game Over Menu
  public void RestartGame()
    {
        SceneManager.LoadScene("Prototype 2");
    }

    //Switch to Home Menu From Game Over Scene
  public void HomeMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
