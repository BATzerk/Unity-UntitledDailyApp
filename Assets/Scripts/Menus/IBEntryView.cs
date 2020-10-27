using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IBEntryView : MonoBehaviour
{
    // Components
    [SerializeField] private TMP_InputField if_belief = null;
    [SerializeField] private TMP_InputField if_debate = null;


    // ================================================================
    //  Initialize
    // ================================================================
    public void Initialize(RectTransform rt_parent, IBData myData)
    {
        // Parent me properly
        GameUtils.ParentAndReset(gameObject, rt_parent);
        
        // Update texts
        if_belief.text = myData.belief;
        if_debate.text = myData.debate;
    }


}
