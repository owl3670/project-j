using UnityEngine;
using UnityEngine.UI;

public class UICriminalCaseDescription : MonoBehaviour
{
    public Text TextCaseNum;
    public Text TextDefendant;
    public Text TextVictim;
    public Text TextCaseDescription;
    public Text TextLawyer;
    public Text TextProsecutor;

    public void SetCaseDescription(CriminalCase criminalCase)
    {
       this.TextCaseNum.text = criminalCase.Num;
       this.TextDefendant.text = criminalCase.Defendant.FullName;
       this.TextVictim.text = criminalCase.Victim.FullName;
       this.TextCaseDescription.text = criminalCase.Description;
       this.TextLawyer.text = criminalCase.Lawyer.FullName;
       this.TextProsecutor.text = criminalCase.Prosecutor.FullName;
    }
}