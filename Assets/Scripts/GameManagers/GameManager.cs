using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameDataManager GameDataManager { get; set; }

    public GameEventManager GameEventManager { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        this.GameDataManager = new GameDataManager();
        this.GameEventManager = new GameEventManager(this.GameDataManager);
    }

    // Update is called once per frame
    void Update()
    {
       this.GameEventManager.GenerateEvent();
    }
}
