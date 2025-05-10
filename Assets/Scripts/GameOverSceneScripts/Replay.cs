using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Game1Scene");
    }

    public void GoHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
