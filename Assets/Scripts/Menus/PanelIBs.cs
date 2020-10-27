using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelIBs : BasePanel
{
    // Components
    [SerializeField] private TextMeshProUGUI t_date = null;
    [SerializeField] private RectTransform rt_entriesParent = null;
    private List<IBEntryView> entryViews;



    // ================================================================
    //  Start
    // ================================================================
    void Start() {
        DateTime thisDate = DateTime.Today;


        // Refresh date text
        t_date.text = TextUtils.MediumDateString(thisDate);


        // Load datas.
        List<IBData> loadedDatas = new List<IBData>();
        int index = 0;
        while (true)
        {
            string saveKey = SaveStorage.GetString(SaveKeys.IBEntry(thisDate, index));
            if (!SaveStorage.HasKey(saveKey)) { break; } // No save entry? Quit the loop.
            string saveDataString = SaveStorage.GetString(saveKey);
            IBData data = JsonUtility.FromJson<IBData>(saveDataString);
            loadedDatas.Add(data);
            if (index++ > 99) { break; } // Safety check.
        }



        // Populate entryViews.
        entryViews = new List<IBEntryView>();
        for (int i=0; i<loadedDatas.Count; i++)
        {
            IBEntryView newView = Instantiate(ResourcesHandler.Instance.IBEntryView).GetComponent<IBEntryView>();
            newView.Initialize(rt_entriesParent, loadedDatas[i]);
            entryViews.Add(newView);
        }
    }





    // ================================================================
    //  Events
    // ================================================================
    public void AddIBEntryView()
    {
        IBEntryView newView = Instantiate(ResourcesHandler.Instance.IBEntryView).GetComponent<IBEntryView>();
        newView.Initialize(rt_entriesParent, new IBData());
        entryViews.Add(newView);
    }




}
