using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficulty : MonoBehaviour
{

public static IEnumerator dif_time()
    {
        while(move.speed != 5.6f)
        {
            move.speed += 0.2f;
            yield return new WaitForSeconds(5);
        }
    }
}
