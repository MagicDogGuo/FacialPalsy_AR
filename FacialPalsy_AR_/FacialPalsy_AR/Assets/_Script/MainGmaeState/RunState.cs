using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : IMainGameState
{

    public RunState(MainGameStateControl Controller) : base(Controller)  //Controller=GameLoop的m_SceneStateController
    {
        this.StateName = "RunState";
    }

    //開始
    public override void StateBegin()
    {

    }

    //更新
    public override void StateUpdate()
    {
        //m_Conrtoller.SetState(MainGameStateControl.GameFlowState.Toturial, m_Conrtoller);
    }


    //結束
    public override void StateEnd()
    {
        DlibFaceLandmarkDetectorExample.WebCamTextureToMatHelperExampleMine.BlinkingEye = null;///////////
        DlibFaceLandmarkDetectorExample.WebCamTextureToMatHelperExampleMine.TOTAL = 0;
        MainGameManager.Instance.ExitDestoryObject();

    }

   
}
