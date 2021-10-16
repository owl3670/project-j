using System;

public class CriminalCase : Case
{
    public CriminalCase()
    {
        this.Category = new CriminalCaseCategory();
        this.Victim = new Character();
        this.Prosecutor = new Character();
        this.Lawyer = new Character();
    }

    public CriminalCaseCategory Category { get; set; }

    public Character Victim { get; set; }

    public Character Prosecutor { get; set; }

    public Character Lawyer { get; set; }
}