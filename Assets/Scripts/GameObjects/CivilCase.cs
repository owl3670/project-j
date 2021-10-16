using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilCase : Case
{
    public CivilCase()
    {
        this.Category = new CivilCaseCategory();
        this.Plaintiff = new Character();
    }

    public CivilCaseCategory Category { get; set; }

    public Character Plaintiff { get; set; }
}