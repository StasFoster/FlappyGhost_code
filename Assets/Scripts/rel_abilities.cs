using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rel_abilities : MonoBehaviour
{
    public Rigidbody player;
    public Collider _Player;
    public float speed;
    private void Update()
    {
        rel_jamp();
        rel_ghost();
        rel_small();
    }
    public void rel_jamp()
    {
        if (abilities._jamp)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.AddForce(transform.up * speed, ForceMode.Acceleration);
            }
        }
    }
    public void rel_ghost()
    {
        if (abilities._ghostmode)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.AddForce(transform.up * speed, ForceMode.Acceleration);
            }
        }
    }
    public void rel_small()
    {
        if (abilities._smallcollaider)
        {

        }
    }
}