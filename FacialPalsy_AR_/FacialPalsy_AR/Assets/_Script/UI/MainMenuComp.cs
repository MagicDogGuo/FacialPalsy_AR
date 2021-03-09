using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuComp : MonoBehaviour
{
    [SerializeField]
    Button ARGameBtn;

    [SerializeField]
    Button RecoverBtn;

    [SerializeField]
    Button RankBtn;

    [SerializeField]
    Button MasachiBtn;

    // Start is called before the first frame update
    void Start()
    {
        ARGameBtn.onClick.AddListener(() => { if (GameEventSystem.Instance.OnPushARSceneBtn != null) GameEventSystem.Instance.OnPushARSceneBtn(0); });
        RecoverBtn.onClick.AddListener(()=> { GameEventSystem.Instance.OnPushRecoverCurveBtn(); }); //SceneManager.LoadScene("RecoverCurve"); });
        RankBtn.onClick.AddListener(() => { GameEventSystem.Instance.OnPushRankBtn(); }); //SceneManager.LoadScene("RecoverCurve"); });
        MasachiBtn.onClick.AddListener(() => { GameEventSystem.Instance.OnPushMasachiBtn(); }); //SceneManager.LoadScene("RecoverCurve"); });


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
