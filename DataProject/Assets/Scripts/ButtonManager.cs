using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameManager gm;
    public GameObject ingame;
    public Button New;
    public Button Loadgame;
    public Button Reset;
    public Button Levelup;
    public Button Exit;
    public Text text;

    private void Start()
    {
        gm = GetComponent<GameManager>();
        New.onClick.AddListener(NewGame);
        Loadgame.onClick.AddListener(ContinueGame);
        Reset.onClick.AddListener(ResetGame);
        Levelup.onClick.AddListener(LevelUP);
        Exit.onClick.AddListener(ExitGame);
    }

    private void NewGame()
    {
        gm.NewSave();
        ingame.SetActive(true);
    }

    private void ContinueGame()
    {
        gm.LoadSave();
        ingame.SetActive(true);
    }

    private void ResetGame()
    {
        gm.ResetSave();
    }

    private void LevelUP()
    {
        gm.LevelUp();
    }

    private void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("Player"))
        {
            Loadgame.interactable = true;
        }
        else
        {
            Loadgame.interactable = false;
        }
    }

    private void LateUpdate()
    {
        int[] StatArr = gm.ReturnStat();

        text.text = $"Level : {StatArr[3]}\nHP : {StatArr[0]}\nATK : {StatArr[1]}\nDEF : {StatArr[2]}";
    }
}
