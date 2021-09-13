using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case
{
    public Case()
    {
        this.OccuredDateTime = DateTime.Now;
        this.TargetFinishedDateTime = DateTime.Now.AddMinutes(5);
        this.Description = "Test 사건입니다";
        this.Defendant = new Defendant();
    }

    public DateTime OccuredDateTime { get; set; }

    public DateTime FinishedDateTime { get; set; }

    public DateTime TargetFinishedDateTime { get; set; }

    public string Description { get; set; }

    public Defendant Defendant { get; set; }
}