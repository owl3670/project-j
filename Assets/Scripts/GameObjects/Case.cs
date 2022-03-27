using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Case
{
    public Case()
    {
        this.OccuredDateTime = DateTime.Now;
        this.TargetFinishedDateTime = DateTime.Now.AddMinutes(5);
        this.Defendant = new Character();
    }

    public string Num { get; set; }

    public DateTime OccuredDateTime { get; set; }

    public DateTime FinishedDateTime { get; set; }

    public DateTime TargetFinishedDateTime { get; set; }

    public string Description { get; set; }

    public Character Defendant { get; set; }

    public (int, int) MandatoryLawNum { get; set; }

    public List<(int, int)> AdditionalLawNums { get; set; }

    public List<CommutationReason> PossibleCommutationReasons { get; set; }
}