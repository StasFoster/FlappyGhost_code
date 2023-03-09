using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class generator : MonoBehaviour
{
    public List<GameObject> blocks = new List<GameObject>();
    public GameObject first, coin;
    public static List<GameObject> set_map = new List<GameObject>();
    public static List<GameObject> set_coin = new List<GameObject>();
    public Transform player;
    System.Random ran = new System.Random();
    private void Awake()
    {
        set_map.Add(first);
    }
    private void Update()
    {
        if(gameover.game_end == false) creat_block();
    }
    private void creat_block()
    {
        int id = ran.Next(1, 9);
        switch (id)
        {
            case 1:
                take_pos(0);
                break;
            case 2:
                take_pos(1);
                break;
            case 3:
                take_pos(2);
                break;
            case 4:
                take_pos(3);
                break;
            case 5:
                take_pos(4);
                break;
            case 6:
                take_pos(5);
                break;
            case 7:
                take_pos(6);
                break;
            case 8:
                take_pos(7);
                break;
            case 9:
                take_pos(8);
                break;

        }

    }
    public void take_pos(int n)
    {
        if (set_map.Last().transform.position.z <= player.position.z + 20f)
        {
            GameObject a = Instantiate(blocks[n], set_map.Last().transform.Find("point").transform.position, Quaternion.identity);
            set_map.Add(a);
            int chanse = ran.Next(1, 4);
            Debug.Log(chanse);
            if (chanse == 3)
            {
                Debug.Log("creat");
                int idcoin = ran.Next(1, 16);
                Debug.Log(idcoin);
                GameObject b = Instantiate(coin, set_map.Last().transform.Find(Convert.ToString(idcoin)).transform.position, Quaternion.identity);
                set_coin.Add(b);
            }

        }
        if (set_map[0].transform.position.z <= player.position.z - 20f)
        {
            Destroy(set_map[0]);
            set_map.RemoveAt(0);       
        }
        if (set_coin.Count > 1) 
        { 
            if (set_coin[0].transform.position.z <= player.position.z - 20f)
            {
                Destroy(set_coin[0]);
                set_coin.RemoveAt(0);
            }
        }
    }
}
