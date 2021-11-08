using UnityEngine;
using UnityEngine.UI;

public class UICriminalCaseSentence : MonoBehaviour
{
    private CriminalCaseSentence sentence;

    public Text TextSentenceYear;
    public Text TextSentenceMonth;

    public void SetSentence(CriminalCaseSentence sentence)
    {
        this.sentence = sentence;
        this.TextSentenceYear.text = this.sentence.Year.ToString();
        this.TextSentenceMonth.text = this.sentence.Month.ToString();
    }

    public void CountUpYear()
    {
        this.sentence.Year++;
        this.TextSentenceYear.text = this.sentence.Year.ToString();
    }

    public void CountDownYear()
    {
        this.sentence.Year--;
        this.TextSentenceYear.text = this.sentence.Year.ToString();
    }

    public void CountUpMonth()
    {
        this.sentence.Month++;
        this.TextSentenceMonth.text = this.sentence.Month.ToString();
    }

    public void CountDownMonth()
    {
        this.sentence.Month--;
        this.TextSentenceMonth.text = this.sentence.Month.ToString();
    }
}