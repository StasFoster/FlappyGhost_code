using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody player;
    public Transform player_pos;
    public static float speed = 1f;
    public static int pos = 0;
    private void Update()
    {
        if (gameover.game_end == false)
        {
            moveing();
            transport();
        }
        else player.velocity = new Vector3(0f, 0f, 0f);
    }
    private void moveing()
    {
        Vector3 run = new Vector3(0f, 0f, 1f);
        player.velocity = run * speed;
    }
    private void transport()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(pos - 1 >= 0)
            {
                pos--;
                player_pos.position = new Vector3(player_pos.position.x - 1f, player_pos.position.y, player_pos.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (pos + 1 <= 3)
            {
                pos++;
                player_pos.position = new Vector3(player_pos.position.x + 1f, player_pos.position.y, player_pos.position.z);
            }
        }
    }
}
