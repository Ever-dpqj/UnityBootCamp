using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public GameObject RuleUI;

    private void Start()
    {
        button1.onClick.AddListener(GameStart);
        button2.onClick.AddListener(RuleView);
        button3.onClick.AddListener(GameExit);
    }

    private void GameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void RuleView()
    {
        RuleUI.SetActive(true);
    }

    private void GameExit()
    {
#if UNITY_EDITOR
        //EditorApplication.Exit(0);
        //유니티 에디터 종료
        EditorApplication.isPlaying = false;
        //유니티 에디터 게임모드 종료   
#else
        Application.Quit();
#endif
    }
}
