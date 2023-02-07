using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score_test;
    public static int _score = 0;

    private void Update()
    {
        score_test.text = Convert.ToString(_score);
        _score = (int)player.position.z;
    }
}
