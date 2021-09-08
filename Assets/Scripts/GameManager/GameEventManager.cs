using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager
{
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
