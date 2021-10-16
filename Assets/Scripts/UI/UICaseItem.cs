using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICaseItem : MonoBehaviour
{
    private Case m_Case;

    public Text TextCaseType;
    public Text TextCaseNum;
    public Text TextCaseCategory;
    public Toggle Toggle;

    public Case Case
    {
        get { return this.m_Case; }
        set
        {
            this.m_Case = value;
            switch (this.m_Case)
            {
                case CriminalCase criminalCase:
                    {
                        this.TextCaseType.text = "CRIMINAL";
                        this.TextCaseNum.text = this.Case.Num;
                        this.TextCaseCategory.text = criminalCase.Category.ToString();
                    }
                    break;
                case CivilCase civilCase:
                    {
                        this.TextCaseType.text = "CIVIL";
                        this.TextCaseNum.text = this.Case.Num;
                        this.TextCaseCategory.text = civilCase.Category.ToString();
                    }
                    break;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }
}
