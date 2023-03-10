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
        jamp.onClick.AddListener(set_active1);
        ghostmode.onClick.AddListener(set_active2);
        smallcollaider.onClick.AddListener(set_active3);
    }
    void set_active1()
    {
        _jamp = true;
        _ghostmode = false;
        _smallcollaider = false;
    }
    void set_active2()
    {
        _jamp = false;
        _ghostmode = true;
        _smallcollaider = false;
    }
    void set_active3()
    {
        _jamp = false;
        _ghostmode = false;
        _smallcollaider = true;
    }
}
