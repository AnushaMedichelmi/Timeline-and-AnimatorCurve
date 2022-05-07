using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField]
    public AnimationCurve animationCurve;
    Animation animations;
    // public float curveTime = 4f;
     public float playerSpeed = 6f;
    // public Vector3 currentPosition;
    public Transform currentTransform;
    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animation>();
       // animationCurve.Evaluate(curveTime);

    }

    // Update is called once per frame
    void Update()
    {
        /*currentPosition = transform.position;
       currentPosition.z+=playerSpeed+Time.deltaTime;
       curveTime= Mathf.Clamp(curveTime, Time.time, 10f);

       currentPosition.y= animationCurve.Evaluate(curveTime*Time.deltaTime);
       transform.position= currentPosition;*/

        currentTransform.position += playerSpeed * currentTransform.forward * Time.deltaTime;
        float valueY= animationCurve.Evaluate(Mathf.PingPong(Time.time,1f));
        currentTransform.position = new Vector3(currentTransform.position.x, valueY, currentTransform.position.z);

        //character track
        //audio track
        //particleeffect track
        //cinemachine track
    }
}
