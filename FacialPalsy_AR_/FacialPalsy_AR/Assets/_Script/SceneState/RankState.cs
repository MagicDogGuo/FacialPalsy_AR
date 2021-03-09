using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankState : ISceneState
{
    public RankState(SceneStateControler controler) : base(controler)
    {
        this.StateName = "RankState";
    }
    public override void StateBegin()
    {
        GameEventSystem.Instance.OnPushBackMainMenu_RankBtn += PushBackSceneBtn;
    }

    public override void StateUpdate()
    {
    }

    public override void StateEnd()
    {
        GameEventSystem.Instance.DisRegistEvents_Rank();
    }

    void PushBackSceneBtn()
    {
        m_Controler.SetState(new MainMenuState(m_Controler), "MainMenuState");
    }
}
