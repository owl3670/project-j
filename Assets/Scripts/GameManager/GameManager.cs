using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CaseUI;

    public GameDataManager GameDataManager { get; set; }

    public GameEventManager GameEventManager { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        this.GameDataManager = new GameDataManager();
        this.GameEventManager = new GameEventManager();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GameDataManager.CurrentCaseCount < 5)
        {
            Case newCase = this.GameEventManager.CreateNewCase();
            this.GameDataManager.AddCase(newCase);
            Debug.Log("Case Created and Added");
        }
    }

    public void OnCaseButtonClick()
    {
        this.CaseUI.SetActive(true);
        Debug.Log("Turn On");
    }

    public void OnCaseButtonExitClick()
    {
        this.CaseUI.SetActive(false);
        Debug.Log("Turn Off");
    }
}
