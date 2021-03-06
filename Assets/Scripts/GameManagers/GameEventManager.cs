using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager
{
    public GameEventManager(GameManager gameManager)
    {
        this.GameManager = gameManager;
    }

    private GameManager GameManager { get; set; }

    private (Case, Sentence) CreateNewCaseAndSentence()
    {
        int randNum = Random.Range(0, 50);
        this.GameManager.GameDataManager.LastGeneratedCaseNum += randNum;
        string caseNum = $"10{(this.GameManager.GameDataManager.LastGeneratedCaseNum).ToString("D8")}";

        List<Character> characters = this.GameManager.GameDataManager.Characters;
        int defendantRandNum = Random.Range(0, characters.Count);
        int notDefendantRandNum;
        do
        {
            notDefendantRandNum = Random.Range(0, characters.Count);
        } while (notDefendantRandNum == defendantRandNum);

        int caseRandNum = Random.Range(0, 2);
        switch (caseRandNum)
        {
            //caseRandNum 값이 0일시 민사사건 생성
            case 0:
                // return (new CivilCase()
                // {
                //     Num = caseNum,
                //     Defendant = characters[defendantRandNum],
                //     Plaintiff = characters[notDefendantRandNum],
                // }, new CivilCaseSentence()
                // );
            //caseRandNum 값이 1일시 형사사건 생성
            case 1:
            default:
                return (new CriminalCase()
                {
                    Num = caseNum,
                    Category = CriminalCaseCategory.Murder,
                    Defendant = characters[defendantRandNum],
                    Victim = characters[notDefendantRandNum],
                }, new CriminalCaseSentence()
                );

        }
    }

    public void GenerateEvent()
    {
        if (this.GameManager.GameDataManager.CurrentCaseCount < 10)
        {
            (Case, Sentence) casePair = this.CreateNewCaseAndSentence();
            this.GameManager.GameDataManager.AddCurrentCase(casePair);
            this.GameManager.UICase.AddNewCaseItem(casePair.Item1);
        }
    }
}
