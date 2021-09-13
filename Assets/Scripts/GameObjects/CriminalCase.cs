using System;

public class CriminalCase : Case
{
    public CriminalCaseType CaseType { get; set; }

    public Victim Victim { get; set; }
}