using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class titleScene : MonoBehaviour
{
    public Button start;
    public Button quit;

    void Start()
    {
        start.onClick.AddListener(OnStartClick);
        quit.onClick.AddListener(OnQuitClick);
    }

    private void OnStartClick()
    {
        SceneManager.LoadScene("EventScene");
    }

    private void OnQuitClick()
    {
        Application.Quit();
    }
}
