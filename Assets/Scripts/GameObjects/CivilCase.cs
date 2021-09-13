using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilCase : Case
{
    public CivilCaseType CaseType { get; set; }

    public Complainant Complainant { get; set; }
}