using UnityEngine;
using UnityEngine.UI;

public class UICase : MonoBehaviour
{
    public GameObject CaseItemPrefab;
    public GameObject UIInstance;
    public GameObject CaseItemList;
    public ToggleGroup ToggleGroup;

    public UICivilCaseDescription UICivilCaseDescription;
    public UICriminalCaseDescription UICriminalCaseDescription;

    public void OpenCaseUI()
    {
        if (!this.UIInstance.activeSelf)
            this.UIInstance.SetActive(true);
    }

    public void CloseCaseUI()
    {
        if (this.UIInstance.activeSelf)
            this.UIInstance.SetActive(false);
    }

    public void ClickCaseItem(Case newCase)
    {
        switch (newCase)
        {
            case CriminalCase criminalCase:
                {
                    this.UICriminalCaseDescription.SetCaseDescription(criminalCase);
                    this.UICriminalCaseDescription.gameObject.SetActive(true);
                    this.UICivilCaseDescription.gameObject.SetActive(false);
                }
                break;
            case CivilCase civilCase:
                {
                    this.UICivilCaseDescription.SetCaseDescription(civilCase);
                    this.UICivilCaseDescription.gameObject.SetActive(true);
                    this.UICriminalCaseDescription.gameObject.SetActive(false);
                }
                break;
        }
    }

    public void AddNewCaseItem(Case newCase)
    {
        GameObject caseItemInstance = Instantiate(this.CaseItemPrefab);
        UICaseItem caseItem = caseItemInstance.GetComponent<UICaseItem>();
        caseItem.Case = newCase;
        caseItemInstance.transform.SetParent(this.CaseItemList.transform);
        caseItem.Toggle.group = this.ToggleGroup;
        caseItem.Toggle.onValueChanged.AddListener(delegate
        {
            this.ClickCaseItem(caseItem.Case);
        });
    }
}