using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float offset;

    [SerializeField]
    private Vector3 dynamicOffset;

    [SerializeField]
    private float smoothSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        //player follow basic
        
        /*Vector3 position = new Vector2(target.position.x, target.position.y + offset);
        transform.position = position;*/
        

        //dynamic + smooth follow
        Vector3 vector3TargetPos = new Vector3(target.position.x, target.position.y);
        Vector3 desiredPos = vector3TargetPos + dynamicOffset;

        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothPosition;//
    }
}
