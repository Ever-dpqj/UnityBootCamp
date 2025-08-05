using UnityEngine;
using UnityEngine.UI;


//Ű�� �Է¹����� Ư�� �޼��� ���

public class LegacyExample : MonoBehaviour
{
    public Text text;


    private void Start()
    {
        text = GetComponentInChildren<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "space";
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            text.text = "enter";
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            text.text = "esc";
        }
    }
}
