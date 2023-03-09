using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select_coin : MonoBehaviour
{
    MeshRenderer obj;
    private void Start()
    {
        obj = GetComponent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        economy.coins++;
        obj.enabled = !obj.enabled;
    }
}
