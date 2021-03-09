﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecoverUIComp : MonoBehaviour
{
    [SerializeField]
    Button backBtn;

    // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(() => { GameEventSystem.Instance.OnPushBackMainMenu_RecoverBtn(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
