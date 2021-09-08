using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public JudgeRank PlayerJudgeRank { get; set; }

    public Dictionary<JudgeRank, List<Judge>> Judges { get; set; }

    public List<Case> EndCases { get; set; }
}
