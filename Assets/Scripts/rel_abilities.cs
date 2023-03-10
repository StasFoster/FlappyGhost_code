using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rel_abilities : MonoBehaviour
{
    public Rigidbody player;
    public BoxCollider _Player;
    public float speed;
    bool active = true;
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
            if (active == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    active = false;
                    player.AddForce(transform.up * speed, ForceMode.Acceleration);
                    StartCoroutine(set_time_active(5));
                }
            }
        }
    }
    public void rel_ghost()
    {
        if (abilities._ghostmode)
        {
            if (active == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    active = false;
                    StartCoroutine(time_active(5));
                    StartCoroutine(set_time_active(15));
                }
            }
        }
    }
    public void rel_small()
    {
        if (abilities._ghostmode)
        {
            _Player.size = new Vector3(0.2f, 0.2f, 0.2f);
        }
        else;
        {
            _Player.size = new Vector3(0.7f, 0.7f, 0.7f);
        }
    }
    public IEnumerator set_time_active(int a)
    {
        for (int i = 0; i <= a; i++)
        {
            yield return new WaitForSeconds(1f);
        }
        active = true;
    }
    public IEnumerator time_active(int a)
    {
        _Player.isTrigger = true;
        for (int i = 0; i <= a; i++)
        {

            yield return new WaitForSeconds(1f);
        }
        _Player.isTrigger = false;
    }
}