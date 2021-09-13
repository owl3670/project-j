using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnvironmentDataManager
{
    public GameEnvironmentDataManager()
    {
        this.GameEnvironmentData = new GameEnvironmentData();
    }

    public GameEnvironmentData GameEnvironmentData { get; set; }
}
