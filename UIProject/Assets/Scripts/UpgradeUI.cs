using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour
{
    public UnitInventory inventory;

    public Button button01;
    public Text message;
    public Text icon_text;
    public Text stat;

    private string[] materials = new string[]
    {
        "100 ���",
        "100 ���+���",
        "200 ���+�����̾�+���¼�",
        "300 ���+���+�����̾�+���¼�",
        "500 ���+���¼�+�����̾�+���",
        "�ִ� ��ȭ �Ϸ�"
    };

    private int upgrade = 0;
    private int max_level => materials.Length - 1;
    private int level = 0;

    private int HP;
    private int ATK;
    private int DEF;


    private void Start()
    {
        inventory = GetComponent<UnitInventory>();
        button01.onClick.AddListener(OnUpgradeBtnClick);
        SetStat();
        UpdateUI();
    }

    private void OnUpgradeBtnClick()
    {
        if (upgrade < max_level)
        {
            Userequire(Readrequire(materials[level]));
        }
    }

    private void UpdateUI()
    {
        icon_text.text = $"������ + {upgrade}";
        message.text = "   �ʿ����\n"+materials[upgrade];
    }

    public int[] Readrequire(string s)
    {
        string[] goldAndetc = s.Split();
        int gold = int.Parse(goldAndetc[0]);
        string[] mat = goldAndetc[1].Split('+');
        int[] mat_num = new int[4]{0, 0, 0, 0};
        mat_num[0] = gold;
        for(int i = 1; i < mat.Length; i++)
        {
            switch(mat[i])
            {
                case "���":
                    mat_num[i] = 2;
                    break;
                case "�����̾�":
                    mat_num[i] = 3;
                    break;
                case "���¼�":
                    mat_num[i] = 4;
                    break;
            }
        }
        //Debug.Log($"{mat_num[0]},{mat_num[1]},{mat_num[2]},{mat_num[3]}");
        return mat_num;
        // mat_num�� [(gold), (mat1), (mat2), (mat3)]�̰�
        // gold�� �ʿ��� ����� ��,
        // int mat ��
        // 2 : ���
        // 3 : �����̾�
        // 4 : ���¼�
        // �� ���Ѵ�
    }

    public void Userequire(int[] mat_num)
    {
        if (inventory.Isleft(1, mat_num[0]) && inventory.Isleft(mat_num[1], 1) && inventory.Isleft(mat_num[2], 1) && inventory.Isleft(mat_num[3], 1))
        {
            inventory.mat_lose(1, mat_num[0]);
            for (int i = 1; i < 4; i++)
            {
                inventory.mat_lose(mat_num[i], 1);
            }
            level++;
            upgrade++;
            StatUp();
            UpdateUI();
        }
        else
        {
            Debug.Log("��ᰡ �����մϴ�");
        }
    }

    private void SetStat()
    {
        HP = 100;
        ATK = 20;
        DEF = 10;
        ShowStat();
    }

    private void StatUp()
    {
        HP += 20;
        ATK += 8;
        DEF += 5;
        ShowStat();
    }

    private void ShowStat()
    {
        stat.text = $"HP : {HP}, ATK : {ATK}, DEF : {DEF}";
    }
}