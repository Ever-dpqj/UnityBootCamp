using UnityEngine;
using UnityEngine.UI;

public class UnitInventory : MonoBehaviour
{
    public Text inven;
    private int gold;
    private int ruby;
    private int sapphire;
    private int magic_stone;

    public Button goldB;
    public Button rubyB;
    public Button sappB;
    public Button stonB;

    void Start()
    {
        goldB.onClick.AddListener(getGold);
        rubyB.onClick.AddListener(getRuby);
        sappB.onClick.AddListener(getSapp);
        stonB.onClick.AddListener(getSton);

        UpdateInven();
    }

    private void getGold()
    {
        mat_get(1, 100);
    }
    private void getRuby()
    {
        mat_get(2, 1);
    }
    private void getSapp()
    {
        mat_get(3, 1);
    }
    private void getSton()
    {
        mat_get(4, 1);
    }


    public void mat_get(int mat_num, int amount)
    {
        switch (mat_num)
        {
            case 1:
                gold += amount;
                break;
            case 2:
                ruby += amount;
                break;
            case 3:
                sapphire += amount;
                break;
            case 4:
                magic_stone += amount;
                break;
        }
        UpdateInven();
    }

    public void mat_lose(int mat_num, int amount)
    {
        switch (mat_num)
        {
            case 0:
                break;
            case 1:
                gold -= amount;
                break;
            case 2:
                ruby -= amount;
                break;
            case 3:
                sapphire -= amount;
                break;
            case 4:
                magic_stone -= amount;
                break;
        }
        UpdateInven();
    }

    public bool Isleft(int mat_num, int amount)
    {
        switch (mat_num)
        {
            case 0:
                return true;
            case 1:
                if (gold - amount >= 0) return true;
                break;
            case 2:
                if (ruby - amount >= 0) return true;
                break;
            case 3:
                if (sapphire - amount >= 0) return true;
                break;
            case 4:
                if (magic_stone - amount >= 0) return true;
                break;
            default:
                return false;
        }
        return false;
    }

    private void UpdateInven()
    {
        inven.text = $"   inventory\n골드 : {gold}\n루비 : {ruby}\n사파이어 : {sapphire}\n마력석 : {magic_stone}";
    }
}
