using System;

public class CriminalCase : Case
{
    public CriminalCaseCategory Category { get; set; }

    public Victim Victim { get; set; }
}