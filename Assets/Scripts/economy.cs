using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class economy : MonoBehaviour
{
    public static int coins = 0;
    public TextMeshProUGUI _coin, _coin2;
    public Button buy;
    private void Start()
    {
        buy.onClick.AddListener(_buy);
    }
    private void Update()
    {
        _coin2.text = Convert.ToString(coins);
        _coin.text = Convert.ToString(coins);
    }
    public void _buy()
    {
        if (coins >= 15) coins -= 15;
        gameover.Liferef++;
    }
}
