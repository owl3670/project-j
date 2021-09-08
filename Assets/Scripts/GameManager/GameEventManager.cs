using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager
{
    public GameEventManager(GameDataManager gameDataManager)
    {
        this.GameDataManager = gameDataManager;
    }

    private GameDataManager GameDataManager { get; }

    public void GenerateEvent()
    {
        if (this.GameDataManager.CurrentCaseCount < 5)
        {
            Case newCase = this.CreateNewCase();
            this.GameDataManager.AddCase(newCase);
            Debug.Log("Case Created and Added");
        }
    }

    public Case CreateNewCase()
    {
        int randNum = Random.Range(0, 2);

        switch (randNum)
        {
            //randNum 값이 0일시 민사사건 생성
            case 0:
                return new CivilCase();
            //randNum 값이 1일시 형사사건 생성
            case 1:
            default:
                return new CriminalCase();

        }
    }
}
