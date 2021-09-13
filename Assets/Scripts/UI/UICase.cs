using UnityEngine;

public class UICase : MonoBehaviour
{
    public GameObject UIInstance;

    public void OpenCaseUI()
    {
        this.UIInstance.SetActive(true);
        Debug.Log("Turn On");
    }

    public void CloseCaseUI()
    {
        this.UIInstance.SetActive(false);
        Debug.Log("Turn Off");
    }
}