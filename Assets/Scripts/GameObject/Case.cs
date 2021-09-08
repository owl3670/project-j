using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case
{
    public DateTime OccuredDateTime{get; set;}

    public DateTime FinishedDateTime{get; set;}

    public DateTime TargetFinishedDateTime{get; set;}

    public string Description{get; set;}

    public Defendant Defendant{get; set;}
}