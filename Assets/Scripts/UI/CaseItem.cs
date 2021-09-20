using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaseItem : MonoBehaviour
{
    private Text textCaseType;
    private Text textCaseNum;
    private Text textCaseCategory;

    public Case Case {get; set;}

    // Start is called before the first frame update
    void Start()
    {
        this.textCaseType = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
