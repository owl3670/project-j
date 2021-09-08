using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CaseUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
