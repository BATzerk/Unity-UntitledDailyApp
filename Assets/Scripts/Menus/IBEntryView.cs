using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IBEntryView : MonoBehaviour
{
    // Components
    [SerializeField] private InputField if_belief = null;
    [SerializeField] private InputField if_debate = null;
    // References
    private PanelIBs myPanel;
    private IBData myData;
    // Properties
    private bool isInitialized=false;

    // ================================================================
    //  Initialize
    // ================================================================
    public void Initialize(PanelIBs _myPanel, IBData _myData)
    {
        this.myData = _myData;
        this.myPanel = _myPanel;

        // Parent me properly
        GameUtils.ParentAndReset(gameObject, myPanel.rt_entriesParent);

        // Update texts
        if_belief.text = myData.belief;
        if_debate.text = myData.debate;

        isInitialized = true;
    }


    public void OnAnyInputFieldChanged()
    {
        if (!isInitialized) { return; } // Skip during initialization.
        myData.belief = if_belief.text;
        myData.debate = if_debate.text;
        PanelIBs.SaveIBData(myData);
    }


}
