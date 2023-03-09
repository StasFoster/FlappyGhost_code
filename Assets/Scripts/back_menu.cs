using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back_menu : MonoBehaviour
{
    public Button back;
    public Transform menu, _gameover, pos_to_screen, pos_over_screen;
    private void Start()
    {
        back.onClick.AddListener(() => StartCoroutine(gameover.Slide(menu, pos_to_screen)));
        back.onClick.AddListener(() => StartCoroutine(gameover.Slide(_gameover, pos_over_screen)));
    }
}
