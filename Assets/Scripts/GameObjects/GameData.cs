using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public GameData()
    {
        this.Judges = new Dictionary<JudgeRank, List<Judge>>();
        this.CurrentCases = new Dictionary<string, (Case, Sentence)>();
        this.EndCases = new List<(Case, Sentence)>();
        this.CriminalLaws = new SortedByArticleLawDictionary();
        this.CivilLaws = new SortedByArticleLawDictionary();
        this.Characters = new List<Character>();
    }

    public Player Player { get; set; }

    public Dictionary<JudgeRank, List<Judge>> Judges { get; set; }

    public Dictionary<string, (Case, Sentence)> CurrentCases { get; set; }

    public List<(Case, Sentence)> EndCases { get; set; }

    public SortedByArticleLawDictionary CriminalLaws { get; set; }

    public SortedByArticleLawDictionary CivilLaws { get; set; }

    public List<Character> Characters { get; set; }

    public int LastGeneratedCaseNum { get; set; }
}
