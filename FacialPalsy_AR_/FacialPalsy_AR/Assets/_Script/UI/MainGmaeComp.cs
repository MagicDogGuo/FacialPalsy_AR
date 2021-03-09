using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainGmaeComp : MonoBehaviour
{
    public Button RestartBtn;

    [SerializeField]
    Button BackMenuBtn;

    // Start is called before the first frame update
    void Start()
    {
        RestartBtn.onClick.AddListener(() => { GameEventSystem.Instance.OnPushRestartBtn(); });
        BackMenuBtn.onClick.AddListener(() => { GameEventSystem.Instance.OnPushBackMainMenu_MainGameBtn(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
