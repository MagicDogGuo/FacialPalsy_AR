using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventSystem : MonoSingleton<GameEventSystem> {
    
    //標題頁
    public UnityAction OnPushLogInBtn;
    public UnityAction OnPushExitBtn;
    public UnityAction OnPushInfoBtn;

    //主選單
    public UnityAction OnPushBackTitleBtn;
    public UnityAction<int> OnPushARSceneBtn;
    public UnityAction OnPushRecoverCurveBtn;
    public UnityAction OnPushRankBtn;
    public UnityAction OnPushMasachiBtn;



    //主遊戲
    public UnityAction OnPushRestartBtn;
    public UnityAction OnPushBackMainMenu_MainGameBtn;

    //恢復曲線
    public UnityAction OnPushBackMainMenu_RecoverBtn;

    //排行
    public UnityAction OnPushBackMainMenu_RankBtn;

    //按摩
    public UnityAction OnPushBackMainMenu_MasachiBtn;

    public void DisRegistEvents_Title()
    {
        OnPushLogInBtn = null;
        OnPushExitBtn = null;
    }


    public void DisRegistEvents_MainMenu()
    {
        OnPushBackTitleBtn = null;
        OnPushARSceneBtn = null;
        OnPushRecoverCurveBtn = null;
        OnPushRankBtn = null;
        OnPushMasachiBtn = null;
    }

    public void DisRegistEvents_MainGame()
    {
        OnPushRestartBtn = null;
        OnPushBackMainMenu_MainGameBtn = null;
    }

    public void DisRegistEvents_Recover()
    {
        OnPushBackMainMenu_RecoverBtn = null;
    }

    public void DisRegistEvents_Rank()
    {
        OnPushBackMainMenu_RankBtn = null;
    }
    public void DisRegistEvents_Masachi()
    {
        OnPushBackMainMenu_MasachiBtn = null;
    }
}
