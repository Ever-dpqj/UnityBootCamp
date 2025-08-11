using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private class Playdata
    {
        public int hp;
        public int atk;
        public int def;
        public int level;

        public void SetPlayer()
        {
            hp = 100;
            atk = 10;
            def = 5;
            level = 1;
            SaveData();
        }

        public void SaveData()
        {
            string dataArr = $"{hp},{atk},{def},{level}";

            PlayerPrefs.SetString("Player", dataArr);
        }

        public void LoadData()
        {
            string[] dataArr = PlayerPrefs.GetString("Player").Split(',');
            hp = int.Parse(dataArr[0]);
            atk = int.Parse(dataArr[1]);
            def = int.Parse(dataArr[2]);
            level = int.Parse(dataArr[3]);
        }

        public void LevelUp()
        {
            hp += 20;
            atk += 5;
            def += 2;
            level++;
            SaveData();
        }
    }


    Playdata Player = new Playdata();

    public void NewSave()
    {
        Player.SetPlayer();
    }

    public void LoadSave()
    {
        Player.LoadData();
    }

    public void ResetSave()
    {
        PlayerPrefs.DeleteAll();
    }

    public void LevelUp()
    {
        Player.LevelUp();
    }

    public int[] ReturnStat()
    {
        int[] StatArr = new int[4] { Player.hp, Player.atk, Player.def, Player.level };
        return StatArr;
    }
}
