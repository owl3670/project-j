using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string FullName { get { return $"{this.LastName} {this.FirstName}"; } }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Moraliry { get; set; }

    public int JudgeScore { get; set; }

    public JudgeRank JudgeRank { get; set; }

    public int Money { get; set; }

    public int Popularity { get; set; }
}
