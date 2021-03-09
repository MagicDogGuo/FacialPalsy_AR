using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    [SerializeField]
    float VelocityPerJump = 100;

    public bool IsTouchCanStand;
    public bool IsDead;


    bool startDelayCount = false;
    float delayCount = 0;
    float delayTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        DlibFaceLandmarkDetectorExample.WebCamTextureToMatHelperExampleMine.BlinkingEye += BoostOnYAxis;

        IsTouchCanStand = false;
        IsDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        //跳鳥
        if (MainGameManager.Instance.WasTouchedOrClicked())
        {
            BoostOnYAxis();
           // DlibFaceLandmarkDetectorExample.WebCamTextureToMatHelperExampleMine.isBlink = false;

        }
    }

    void BoostOnYAxis()
    {
        if(IsTouchCanStand == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, VelocityPerJump);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "CanStand")
        {
            IsTouchCanStand = true;
        }
        if (collision.gameObject.tag == "CannotTouch")
        {
            IsDead = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CanStand")
        {
            IsTouchCanStand = false;

        }
    }
  }
