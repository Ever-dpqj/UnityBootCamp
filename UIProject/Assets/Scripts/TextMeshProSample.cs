using UnityEngine;
using TMPro;

public class TextMeshProSample : MonoBehaviour
{
    public TextMeshProUGUI textUI;

    private void Start()
    {
        textUI.text = "<size=150%>�ȳ��ϼ���</size> <s>���</s>";
    }

    public void SetText(bool warning)
    {
        if (warning)
        {
            textUI.text = "<color=red><b>WARNING!</b></color>";
        }
        else
        {
            textUI.text = "<color=green>NORMAL</color>";
        }
    }
}