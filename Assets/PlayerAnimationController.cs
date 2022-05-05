using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField]
    public AnimationCurve animationCurve;
    Animation animations;
     public float curveTime = 4f;
     public float playerSpeed = 6f;
    public Vector3 currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animation>();
       // animationCurve.Evaluate(curveTime);

    }

    // Update is called once per frame
    void Update()
    {
         currentPosition = transform.position;
        currentPosition.z+=playerSpeed+Time.deltaTime;
        curveTime= Mathf.Clamp(curveTime, Time.time, 10f);

        currentPosition.y= animationCurve.Evaluate(curveTime*Time.deltaTime);
        transform.position= currentPosition;
    }
}
