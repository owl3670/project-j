using System.Collections;
using System.Collections.Generic;

public class CriminalCaseSentence : Sentence
{
    public CriminalCaseSentence()
    {
        this.ReferenceLaws = new List<Law>();
        this.CommutationReasons = new List<CommutationReason>();
    }

    public int Year { get; set; }

    public int Month { get; set; }

    public List<Law> ReferenceLaws { get; set; }

    public List<CommutationReason> CommutationReasons { get; set; }
}