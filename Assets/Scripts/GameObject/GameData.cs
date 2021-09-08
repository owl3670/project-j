using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public GameData()
    {
        this.PlayerJudgeRank = JudgeRank.LEVEL1;
        this.Judges = new Dictionary<JudgeRank, List<Judge>>();
        this.CurrentCases = new List<Case>();
        this.EndCases = new List<Case>();
    }

    public JudgeRank PlayerJudgeRank { get; set; }

    public Dictionary<JudgeRank, List<Judge>> Judges { get; set; }

    public List<Case> CurrentCases { get; set; }

    public List<Case> EndCases { get; set; }
}
