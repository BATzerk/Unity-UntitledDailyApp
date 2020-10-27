using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PanelToday : BasePanel
{
    // Components
    [SerializeField] private TextMeshProUGUI t_date = null;




    // ================================================================
    //  Start
    // ================================================================
    void Start()
    {
        t_date.text = TextUtils.MediumDateString(DateTime.Today);

    }
}
