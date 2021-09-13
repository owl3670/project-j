using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriminalLaw : Law
{
    public CriminalCaseType CaseType { get; set; }

    public int MinSentenceYear { get; set; }

    public int MaxSentenceYear { get; set; }
}