using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : ISceneState
{
    public MainMenuState(SceneStateControler Controler) : base(Controler)
    {
        this.StateName = "MainMenuState";
    }

    public override void StateBegin()
    {
        MainMenuManager.Instance.InstantiateInitObject();
        GameEventSystem.Instance.OnPushARSceneBtn += PushARSceneBtn;
        GameEventSystem.Instance.OnPushRecoverCurveBtn += PushRecoverCurveBtn;
        GameEventSystem.Instance.OnPushRankBtn += PushRankBtn;
        GameEventSystem.Instance.OnPushMasachiBtn += PushMasachiBtn;

    }

    public override void StateUpdate()
    {
    }

    public override void StateEnd()
    {
        GameEventSystem.Instance.DisRegistEvents_MainMenu();
    }

    void PushARSceneBtn(int level)
    {
        m_Controler.SetState(new MainGameState(m_Controler), "MainGameState");
    }

    void PushRecoverCurveBtn()
    {
        m_Controler.SetState(new RecoverCurveState(m_Controler), "RecoverCurveState");
    }

    void PushRankBtn()
    {
        m_Controler.SetState(new RankState(m_Controler), "RankState");
    }
    void PushMasachiBtn()
    {
        m_Controler.SetState(new MasachiState(m_Controler), "MasachiState");
    }

}
