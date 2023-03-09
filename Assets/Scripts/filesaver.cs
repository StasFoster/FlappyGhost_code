using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;


public class filesaver : MonoBehaviour
{
    public Button exit;
    private void Awake()
    {
        Data_game qwe = Load();
        score._max_score = qwe.maxscore;
        gameover.Liferef = qwe.life;
        economy.coins = qwe.coin;
    }
    private void Start()
    {
        exit.onClick.AddListener(_exit);
    }
    public void Save()
    {
        Data_game JSONSER = new Data_game();
        JSONSER.maxscore = score._max_score;
        JSONSER.life = gameover.Liferef;
        JSONSER.coin = gameover.Liferef;
        string data = JsonUtility.ToJson(JSONSER);
        File.WriteAllText(Application.streamingAssetsPath + "/Loadsave.json", data);
    }
    public Data_game Load()
    {
        Data_game JSONDESER = JsonUtility.FromJson<Data_game>(File.ReadAllText(Application.streamingAssetsPath + "/Loadsave.json"));
        return JSONDESER;
    }
    public void _exit()
    {
        Save();
        Application.Quit();
    }
}

