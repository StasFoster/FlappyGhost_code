using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilities : MonoBehaviour
{
    public static bool _jamp, _ghostmode, _smallcollaider;
    public Button jamp, ghostmode, smallcollaider;
    private void Start()
    {
        jamp.onClick.AddListener(() => _jamp = true);
        ghostmode.onClick.AddListener(() => _ghostmode = true);
        smallcollaider.onClick.AddListener(() => _smallcollaider = true);
    }
}
