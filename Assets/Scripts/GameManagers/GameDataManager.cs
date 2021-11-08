using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager
{
    public GameDataManager(GameManager gameManager)
    {
        this.GameManager = gameManager;
        this.GameData = new GameData();
        this.LoadData();
    }

    private GameManager GameManager { get; set; }

    private GameData GameData { get; set; }

    public int CurrentCaseCount { get { return this.GameData.CurrentCases.Count; } }

    public int LastGeneratedCaseNum { get { return this.GameData.LastGeneratedCaseNum; } set { this.GameData.LastGeneratedCaseNum = value; } }

    public List<Character> Characters { get { return this.GameData.Characters; } }

    public Player Player { get { return this.GameData.Player; } }

    public void AddCurrentCase((Case, Sentence) casePair)
    {
        this.GameData.CurrentCases.Add(casePair.Item1.Num, casePair);
    }

    public (Case Case, Sentence Sentence) GetCurrentCase(Case findCase)
    {
        return this.GameData.CurrentCases[findCase.Num];
    }

    public void RemoveCurrentCase(Case endCase)
    {
        this.GameData.CurrentCases.Remove(endCase.Num);
    }

    public void AddEndCase((Case, Sentence) casePair)
    {
        this.GameData.EndCases.Add(casePair);
    }

    public void SaveData()
    {

    }

    public void LoadData()
    {
        //TODO
        //추후 load 할 data 가 없을시에만 아래코드 동작하도록 구현 필요
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

        string[] lastNames = { "서", "오", "김", "조", "박" };
        string[] nameCharacters = { "서", "현", "이", "진", "신", "유", "정", "가" };

        for (int i = 0; i < 100; i++)
        {
            int lastNameRandNum = Random.Range(0, lastNames.Length);
            int nameCharRandNum1 = Random.Range(0, nameCharacters.Length);
            int nameCharRandNum2 = Random.Range(0, nameCharacters.Length);

            int randAge = Random.Range(0, 150);

            Character character = new Character
            {
                LastName = lastNames[lastNameRandNum],
                FirstName = $"{nameCharacters[nameCharRandNum1]}{nameCharacters[nameCharRandNum2]}",
                Age = randAge,
            };

            this.GameData.Characters.Add(character);
        }
    }
}
