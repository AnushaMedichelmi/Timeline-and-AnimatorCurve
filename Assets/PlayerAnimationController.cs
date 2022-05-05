using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField]
    public AnimationCurve animationCurve;
    Animation animations;
    float curveTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animation>();
       // animationCurve.Evaluate(curveTime);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y= animationCurve.Evaluate(curveTime);
        transform.position= currentPosition;
    }
}
