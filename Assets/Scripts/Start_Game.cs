using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Game : MonoBehaviour
{
    public Button start;
    public Transform panel, pos;
    private void Start()
    {
        start.onClick.AddListener(pusk);
    }
    public void pusk()
    {
        gameover.game_end = false;
        move.speed = 1f;
        StartCoroutine(difficulty.dif_time());
        StartCoroutine(gameover.Slide(panel, pos));
    }
}
