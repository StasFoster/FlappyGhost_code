using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class gameover : MonoBehaviour
{
    public TextMeshProUGUI tex;
    public Transform panel, pos, zero_pos_block, zero_pos_player, player;
    public GameObject block;
    private int Life = 3;
    public static Action game_over;
    public static bool game_end = true;
    private void Start()
    {
        tex.text = Convert.ToString(Life);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Life--;
        tex.text = Convert.ToString(Life);
        if (Life <= 0)
        {

            game_end = true;
            foreach (GameObject i in generator.set_map) Destroy(i);
            generator.set_map.Clear();
            StopCoroutine(difficulty.dif_time());
            StartCoroutine(Slide(panel, pos));
            GameObject first = Instantiate(block, zero_pos_block.position, Quaternion.identity);
            generator.set_map.Add(first);
            move.pos = 0;
            Life = 3;
            player.position = zero_pos_player.position;
        }
    }
    public static IEnumerator Slide(Transform a, Transform b)
    {
        while (a.position != b.position)
        {
            a.position = Vector3.MoveTowards(a.position, b.position, 0.01f);
            yield return new WaitForSeconds(0.0001f);
        }
    }
}
