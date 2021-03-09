using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollRecoverUI : MonoBehaviour
{
    [SerializeField]
    GameObject DetectQuadObj;

    public static int Page = 1;


    enum PagePos
    {
        page01=2800,
        page02=1450,
        page03 = 0
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Page)
        {
            case 1:
                this.GetComponent<RectTransform>().anchoredPosition = new Vector3((float)PagePos.page01, GetComponent<RectTransform>().anchoredPosition.y);
                  break;
            case 2:
                this.GetComponent<RectTransform>().anchoredPosition = new Vector3((float)PagePos.page02, GetComponent<RectTransform>().anchoredPosition.y);
                DetectQuadObj.transform.position = Vector3.zero;
                break;
            case 3:
                this.GetComponent<RectTransform>().anchoredPosition = new Vector3((float)PagePos.page03, GetComponent<RectTransform>().anchoredPosition.y);
                DetectQuadObj.transform.position = new Vector3(5000,0,0);

                break;

        }

    }
}
