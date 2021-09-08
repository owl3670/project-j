using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager
{
    public GameDataManager()
    {
        this.GameData = new GameData();
    }

    private GameData GameData { get; set; }

    public int CurrentCaseCount { get { return this.GameData.CurrentCases.Count; } }

    public void AddCase(Case newCase)
    {
        this.GameData.CurrentCases.Add(newCase);
    }
}
