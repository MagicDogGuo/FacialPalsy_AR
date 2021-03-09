using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitState : IMainGameState
{
   
    public InitState(MainGameStateControl Controller) : base(Controller)  //Controller=GameLoop的m_SceneStateController
    {
        this.StateName = "InitState";
    }

    //開始
    public override void StateBegin()
    {
        MainGameManager.Instance.InstantiateInitObject();
        GameEventSystem.Instance.OnPushRestartBtn += RestartState;
        GameEventSystem.Instance.OnPushBackMainMenu_MainGameBtn += RestartState;
    }

    //更新
    public override void StateUpdate() {
        m_Conrtoller.SetState(MainGameStateControl.GameFlowState.Run, m_Conrtoller);
    }


    //結束
    public override void StateEnd() {
       
    }


    void SetBGM(int level)
    {
     
    }

    /// <summary>
    /// 重新開始 0619 改成回選單，方法名我就先不改了
    /// </summary>
    void RestartState()
    {
        m_Conrtoller.SetState(MainGameStateControl.GameFlowState.Init, m_Conrtoller);

    }

    void NextLevel()
    {
        //MainGameManager.NowLevel++;
    }

    void MenuScene()
    {
        m_Conrtoller.SetState(MainGameStateControl.GameFlowState.Init, m_Conrtoller);
    }
}
