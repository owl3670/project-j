using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriminalLaw : Law
{
    public CriminalCaseCategory CaseCategory { get; set; }

    public int MinSentenceYear { get; set; }

    public int MaxSentenceYear { get; set; }

    public bool IsExcutionable { get; set; }
}