using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    // References
    [SerializeField] private BasePanel panel_IBs=null;
    [SerializeField] private BasePanel panel_today=null;


    // ================================================================
    //  Start
    // ================================================================
    void Start()
    {
        ShowPanel(panel_IBs);
        //ShowPanel(panel_today);
    }


    // ================================================================
    //  Doers
    // ================================================================
    public void ShowPanel(BasePanel _panel)
    {
        panel_IBs.SetVisibility(false);
        panel_today.SetVisibility(false);

        _panel.SetVisibility(true);
    }

    // ================================================================
    //  Events
    // ================================================================
    public void OpenPanel_IBs() { ShowPanel(panel_IBs); }
    public void OpenPanel_Today() { ShowPanel(panel_today); }



    // ================================================================
    //  Update
    // ================================================================
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            GameManagers.Instance.DataManager.ClearAllSaveData();
        }
    }

}
