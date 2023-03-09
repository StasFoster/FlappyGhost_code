using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Newtonsoft.Json;
using System;
using System.IO;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score_test, max_s;
    public static int _score = 0;
    public static int _max_score;
    private void Update()
    {
        score_test.text = Convert.ToString(_score);
        _score = (int)player.position.z;
        max_s.text = Convert.ToString(_max_score);
        save_score();
    }
    public void save_score()
    {
        if (_max_score < _score) _max_score = _score;
    }
}