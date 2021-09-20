using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager
{
    public GameDataManager()
    {
        this.GameData = new GameData();
        this.LoadData();
    }

    private GameData GameData { get; set; }

    public int CurrentCaseCount { get { return this.GameData.CurrentCases.Count; } }

    public void AddCase(Case newCase)
    {
        this.GameData.CurrentCases.Add(newCase);
    }

    public void SaveData()
    {

    }

    public void LoadData()
    {
        //TODO
        //추후 load 할 data 가 없으시에만 아래코드 동작하도록 구현 필요
        this.InitData();
    }


    private void InitData()
    {
        //TODO
        //추후 법 생성 알고리즘에 의한 생성방식으로 구현 필요

        this.GameData.CriminalLaws.Add(1, new SortedBySectionLawDictionay());
        this.GameData.CriminalLaws[1].Add(1, new CriminalLaw()
        {
            ArticleNum = 1,
            SectionNum = 1,
            CaseType = CriminalCaseCategory.Murder,
            MinSentenceYear = 2,
            MaxSentenceYear = 5
        });
        this.GameData.CriminalLaws[1].Add(2, new CriminalLaw()
        {
            ArticleNum = 1,
            SectionNum = 2,
            CaseType = CriminalCaseCategory.Murder,
            MinSentenceYear = 2,
            MaxSentenceYear = 5
        });
        this.GameData.CriminalLaws.Add(2, new SortedBySectionLawDictionay());
        this.GameData.CriminalLaws[2].Add(1, new CriminalLaw()
        {
            ArticleNum = 2,
            SectionNum = 1,
            CaseType = CriminalCaseCategory.Thieves,
            MinSentenceYear = 2,
            MaxSentenceYear = 5
        });
        this.GameData.CriminalLaws[2].Add(2, new CriminalLaw()
        {
            ArticleNum = 2,
            SectionNum = 2,
            CaseType = CriminalCaseCategory.Thieves,
            MinSentenceYear = 2,
            MaxSentenceYear = 5
        });
        this.GameData.CriminalLaws[2].Add(3, new CriminalLaw()
        {
            ArticleNum = 2,
            SectionNum = 3,
            CaseType = CriminalCaseCategory.Thieves,
            MinSentenceYear = 2,
            MaxSentenceYear = 5
        });

        this.GameData.CivilLaws.Add(1, new SortedBySectionLawDictionay());
        this.GameData.CivilLaws[1].Add(1, new CivilLaw());
        this.GameData.CivilLaws[1].Add(2, new CivilLaw());
        this.GameData.CivilLaws[1].Add(3, new CivilLaw());
        this.GameData.CivilLaws.Add(2, new SortedBySectionLawDictionay());
        this.GameData.CivilLaws[2].Add(1, new CivilLaw());
        this.GameData.CivilLaws[2].Add(2, new CivilLaw());
    }
}
