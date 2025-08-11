using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class Dialog
{
    public string character;
    public string content;

    public Dialog(string character, string content)
    {
        this.character = character;
        this.content = content;
    }
}

public class DialogManager : MonoBehaviour
{
    #region MonoSingleton
    public static DialogManager instance { get; private set; }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion





    public TMP_Text message;
    public TMP_Text character_name;
    public GameObject panel;
    public float typing_speed;

    private Queue<Dialog> queue = new Queue<Dialog>();
    private Coroutine typing;
    private bool isTyping;
    private Dialog current;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                CompleteLine();
            }
            else
            {
                NextLine();
            }
        }
    }

    public void StartLine(IEnumerable<Dialog> lines)
    {
        queue.Clear();

        foreach(var line in lines)
        {
            queue.Enqueue(line);
        }
        panel.SetActive(true);
    }

    private void CompleteLine()
    {
        if (typing != null)
        {
            StopCoroutine(typing);
        }
    }
    private void NextLine()
    {
        if (queue.Count == 0)
        {
            DialogExit();
            return;
        }

        current = queue.Dequeue();
        character_name.text = current.character;

        if (typing != null)
        {
            StopCoroutine(typing);

            typing = StartCoroutine(TypingDialog(current.content));
        }
    }

    private IEnumerator TypingDialog(string line)
    {
        isTyping = true;
        StringBuilder stringBuilder = new StringBuilder(line.Length);
        message.text = "";

        foreach (char c in line)
        {
            //message.text += c;
            stringBuilder.Append(c);
            message.text = stringBuilder.ToString();
            yield return new WaitForSeconds(typing_speed);
        }
        isTyping = false;
    }

    private void DialogExit()
    {
        panel.SetActive(false);
    }
}