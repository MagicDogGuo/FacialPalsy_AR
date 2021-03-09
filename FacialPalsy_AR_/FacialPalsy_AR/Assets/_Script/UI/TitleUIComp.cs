using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleUIComp : MonoBehaviour
{
    [SerializeField]
    Button LogInBtn;

    // Start is called before the first frame update
    void Start()
    {
        LogInBtn.onClick.AddListener(() => { if (GameEventSystem.Instance.OnPushLogInBtn != null) GameEventSystem.Instance.OnPushLogInBtn(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
