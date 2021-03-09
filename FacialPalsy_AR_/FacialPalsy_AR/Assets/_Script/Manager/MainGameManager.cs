using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{

    static MainGameManager m_Instance;
    public static MainGameManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = FindObjectOfType(typeof(MainGameManager)) as MainGameManager;

                if (m_Instance == null)
                {
                    var gameObject = new GameObject(typeof(MainGameManager).Name);
                    m_Instance = gameObject.AddComponent(typeof(MainGameManager)) as MainGameManager;
                }
            }
            return m_Instance;
        }
    }

    [SerializeField]
    GameObject MainGameUICanvas;

    [SerializeField]
    GameObject PlayerBird;

    [SerializeField]
    GameObject EnemyPool;

    [SerializeField]
    GameObject ColumnPool;

    public bool gameOver = false;
    
    public float scrollSpeed;

    GameObject mainMenuUICanvases;
    public GameObject MainMenuUICanvases
    {
        get { return mainMenuUICanvases; }
        set { mainMenuUICanvases = value; }
    }

    GameObject playerBirds;
    public GameObject PlayerBirds
    {
        get { return playerBirds; }
        set { playerBirds = value; }
    }

    GameObject columnPools;
    public GameObject ColumnPools
    {
        get { return columnPools; }
        set { columnPools = value; }
    }

    GameObject enemyPools;
    public GameObject EnemyPools
    {
        get { return enemyPools; }
        set { enemyPools = value; }
    }


    bool birdisTouchCanStand;
    public bool BirdisTouchCanStand
    {
        get { return playerBirds.GetComponent<Bird>().IsTouchCanStand; }
    }

    bool birdisDaed;
    public bool BirdisDead
    {
        get { return playerBirds.GetComponent<Bird>().IsDead; }
    }


    // 場景狀態
    MainGameStateControl m_MainGameStateController = new MainGameStateControl();
    // 獲取當前的狀態
    public MainGameStateControl.GameFlowState CurrentState
    {
        get { return m_MainGameStateController.GameState; }
    }

    public void MainGameBegin()
    {
        // 設定起始State
        m_MainGameStateController.SetState(MainGameStateControl.GameFlowState.Init, m_MainGameStateController);
 
    }

    public void MainGameUpdate()
    {
        m_MainGameStateController.StateUpdate();
    }


    /// <summary>
    /// 生成主選單初始物件
    /// </summary>
   public void InstantiateInitObject()
   {
        //mainMenuUICanvases = Instantiate(MainGameUICanvas);
        playerBirds = Instantiate(PlayerBird);
        columnPools = Instantiate(ColumnPool);
        enemyPools = Instantiate(EnemyPool);
    }

    public void ExitDestoryObject()
    {
        Destroy(playerBirds);
        Destroy(columnPools);
        Destroy(enemyPools);
    }

    /// <summary>
    /// 跳
    /// </summary>
    /// <returns></returns>
    public bool WasTouchedOrClicked()
    {
        if (Input.GetButtonUp("Jump") || Input.GetMouseButtonDown(0) ||
            (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended))//DlibFaceLandmarkDetectorExample.WebCamTextureToMatHelperExampleMine.isBlink
        {
                return true;
        }
        else
        {
            return false;
        }
    }

}
