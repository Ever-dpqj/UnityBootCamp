using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using UnityEngine.SceneManagement;

public class ItemManager : MonoBehaviour
{
    public event EventHandler GetRareItem;

    public Button Get1;
    public Button Get10;
    public Button quit;
    public GameObject RareWindow;
    public Text text;

    private void Start()
    {
        GetRareItem += OnRareWindow;
        Get1.onClick.AddListener(Get1BtnClick);
        Get10.onClick.AddListener(Get10BtnClick);
        quit.onClick.AddListener(OnQuitClick);
        text.text = "플레이어님이 에픽아이템을 획득했습니다!";
    }

    private void Getitem()
    {
        string[] itemArr = { "사과", "카카오", "옥수수", "토마토", "감자", "버섯", "우유", "달걀", "생강", "에픽아이템" };

        int get_random = UnityEngine.Random.Range(0, 10);

        Debug.Log($"<color=brown>{itemArr[get_random]}</color> 을/를 얻었습니다.");


        if (get_random == 9)
        {
            GetRareItem(this, EventArgs.Empty);
            //Debug.Log(1); //확인용
        }
    }

    private IEnumerator WindowOn()
    {
        RareWindow.SetActive(true);
        yield return new WaitForSeconds(1f);
        RareWindow.SetActive(false);
        yield break;
    }

    private void OnRareWindow(object sender, EventArgs e)
    {
        StartCoroutine(WindowOn());
    }

    private void Get10item()
    {
        int i = 10;
        while (i > 0)
        {
            Getitem();
            i--;
        }
    }

    private void Get1BtnClick()
    {
        Getitem();
    }
    private void Get10BtnClick()
    {
        Get10item();
    }

    private void OnQuitClick()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
