using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slaid_menu : MonoBehaviour
{
    public Button set_score;
    public Transform panel, pos, pos_under;
    bool f = false;
    private void Start()
    {
        set_score.onClick.AddListener(up_panel);
    }
    private void up_panel()
    {
        if(f == false)
        {
            StartCoroutine(Slaid_pro(panel, pos));
        }
        if(f == true)
        {
            StartCoroutine(Slaid_pro(panel, pos_under));
        }
    }
    public IEnumerator Slaid_pro(Transform a, Transform b)
    {
        while((a.position != b.position))
        {
            a.position = Vector3.MoveTowards(a.position, b.position, 0.07f);
            yield return new WaitForSeconds(0.0001f);
        }
        f = !f;
    }
}
