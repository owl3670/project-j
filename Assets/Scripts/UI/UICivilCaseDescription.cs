using UnityEngine;
using UnityEngine.UI;

public class UICivilCaseDescription : MonoBehaviour
{
    public Text TextCaseNum;
    public Text TextDefendant;
    public Text TextCaseDescription;
    public Text TextPlaintiff;

    
    public void SetCaseDescription(CivilCase civilCase)
    {
       this.TextCaseNum.text = civilCase.Num;
       this.TextDefendant.text = civilCase.Defendant.FullName;
       this.TextCaseDescription.text = civilCase.Description;
       this.TextPlaintiff.text = civilCase.Plaintiff.FullName;
    }
}