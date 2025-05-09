using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeMenuController : MonoBehaviour
{
    public Button btnHome;
    public Button btnSettings;
    public Button btnGame1;
    public Button btnGame2;

    void Start()
    {
        btnHome.onClick.AddListener(OnHomeClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnGame1.onClick.AddListener(() => LoadScene("Game1Scene"));
        btnGame2.onClick.AddListener(() => LoadScene("Game2Scene"));
    }

    void OnHomeClicked()
    {
        Debug.Log("Home Pressed");
    }

    void OnSettingsClicked()
    {
        Debug.Log("Settings Pressed");
    }

    void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
