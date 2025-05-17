using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitPromptManager : MonoBehaviour
{
    public GameObject exitDialog;
    public Button yesButton;
    public Button noButton;
    public Button backButton;

    void Start()
    {
        exitDialog.SetActive(false); // 시작 시 숨기기

        // 버튼에 동적 이벤트 연결
        yesButton.onClick.AddListener(OnClickYes);
        noButton.onClick.AddListener(OnClickNo);
        backButton.onClick.AddListener(OnClickBack);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleExitDialog();
        }
    }

    void ToggleExitDialog()
    {
        bool isActive = exitDialog.activeSelf;
        exitDialog.SetActive(!isActive);
        Time.timeScale = !isActive ? 0 : 1;
    }

    void OnClickYes()
    {
        Debug.Log("Exiting game...");
        Time.timeScale = 1;
        SceneManager.LoadScene("HomeScene");
        Application.Quit();
    }

    void OnClickNo()
    {
        exitDialog.SetActive(false);
        Time.timeScale = 1;
    }
    public void OnClickBack()
    {
        ToggleExitDialog();
        Debug.Log("SetActive Second Panel");

    }
}
