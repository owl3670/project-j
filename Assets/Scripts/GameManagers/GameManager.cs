using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager m_Instance = null;
    public static GameManager Instance => m_Instance;

    public UICase UICase;

    public GameDataManager GameDataManager { get; set; }

    public GameEventManager GameEventManager { get; set; }

    void Awake()
    {
        if (m_Instance == null)
        {
            m_Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        this.GameDataManager = new GameDataManager(this);
        this.GameEventManager = new GameEventManager(this);
    }

    // Update is called once per frame
    void Update()
    {
        this.GameEventManager.GenerateEvent();
    }
}
