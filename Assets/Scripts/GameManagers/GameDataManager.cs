using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager
{
    public GameDataManager(GameManager gameManager)
    {
        this.GameManager = gameManager;
        this.GameData = new GameData();
        //TODO 
        //GameManager 에서 생성하도록 변경 필요
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
        //추후 법 생성 알고리즘에 의한 자동 생성방식으로 구현 필요

        this.GameData.CriminalLaws.Add(1, new SortedBySectionLawDictionay());
        this.GameData.CriminalLaws[1].Add(1, new CriminalLaw()
        {
            ArticleNum = 1,
            SectionNum = 1,
            CaseCategory = CriminalCaseCategory.Murder,
            MinSentenceYear = 5,
            MaxSentenceYear = int.MaxValue,
            IsExcutionable = true,
            Title = "보통 살인죄",
            Contents = "사람을 살해한 자는 사형, 무기 또는 5년 이상의 징역에 처한다.",
        });
        this.GameData.CriminalLaws[1].Add(2, new CriminalLaw()
        {
            ArticleNum = 1,
            SectionNum = 2,
            CaseCategory  = CriminalCaseCategory.Murder,
            MinSentenceYear = 7,
            MaxSentenceYear = int.MaxValue,
            Title = "존속 살인죄",
            Contents = "자기 또는 배우자의 직계존속을 살해한 자는 사형, 무기 또는 7년 이상의 징역에 처한다.",
 
        });
        this.GameData.CriminalLaws.Add(2, new SortedBySectionLawDictionay());
        this.GameData.CriminalLaws[2].Add(1, new CriminalLaw()
        {
            ArticleNum = 2,
            SectionNum = 1,
            CaseCategory = CriminalCaseCategory.Thieves,
            MinSentenceYear = 0,
            MaxSentenceYear = 6,
            Title = "절도죄",
            Contents = "타인의 재물을 절취한 자는 6년 이하의 징역에 처한다."
        });
        this.GameData.CriminalLaws[2].Add(2, new CriminalLaw()
        {
            ArticleNum = 2,
            SectionNum = 2,
            CaseCategory = CriminalCaseCategory.Thieves,
            MinSentenceYear = 0,
            MaxSentenceYear = 10,
            Title = "야간 주거 침입 절도죄",
            Contents = "야간에 사람의 주거, 간수하는 저택, 건조물이나 선박 또는 점유하는 방실에 침입하여 타인의 재물을 절취한 자는 10년 이하의 징역에 처한다."
        });
        this.GameData.CriminalLaws[2].Add(3, new CriminalLaw()
        {
            ArticleNum = 2,
            SectionNum = 3,
            CaseCategory = CriminalCaseCategory.Thieves,
            MinSentenceYear = 1,
            MaxSentenceYear = 5,
            Title = "특수 절도죄",
            Contents = "야간에 문호 또는 장벽 기타 건조물의 일부를 손괴하고 전조의 장소에 침입하여 타인의 재물을 절취한 자는 1년 이상 10년 이하의 징역에 처한다."
        });

        this.GameData.CivilLaws.Add(1, new SortedBySectionLawDictionay());
        this.GameData.CivilLaws[1].Add(1, new CivilLaw());
        this.GameData.CivilLaws[1].Add(2, new CivilLaw());
        this.GameData.CivilLaws[1].Add(3, new CivilLaw());
        this.GameData.CivilLaws.Add(2, new SortedBySectionLawDictionay());
        this.GameData.CivilLaws[2].Add(1, new CivilLaw());
        this.GameData.CivilLaws[2].Add(2, new CivilLaw());

        string[] lastNames = { "서", "오", "김", "조", "박", "정", "이", "지", "신" };
        string[] nameCharacters = { "서", "현", "이", "진", "신", "유", "정", "가", "준", "재", "민", "호", "성", "태", "형" };

        // Character 추가
        for (int i = 0; i < 1000; i++)
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
