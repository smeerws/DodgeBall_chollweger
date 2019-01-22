using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    enum Scenes { Welcome, MainScene, GameOver, Won };

    public void LoadWelcomeScene()
    {
        SceneManager.LoadScene((int)Scenes.Welcome);
    }

    public void LoadMainGameScene()
    {
        SceneManager.LoadScene((int)Scenes.MainScene);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene((int)Scenes.GameOver);
    }

    public void LoadWonScene()
    {
        SceneManager.LoadScene((int)Scenes.Won);
    }
}
