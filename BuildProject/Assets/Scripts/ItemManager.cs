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
        text.text = "�÷��̾���� ���Ⱦ������� ȹ���߽��ϴ�!";
    }

    private void Getitem()
    {
        string[] itemArr = { "���", "īī��", "������", "�丶��", "����", "����", "����", "�ް�", "����", "���Ⱦ�����" };

        int get_random = UnityEngine.Random.Range(0, 10);

        Debug.Log($"<color=brown>{itemArr[get_random]}</color> ��/�� ������ϴ�.");


        if (get_random == 9)
        {
            GetRareItem(this, EventArgs.Empty);
            //Debug.Log(1); //Ȯ�ο�
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
