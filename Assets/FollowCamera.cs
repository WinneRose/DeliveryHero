using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objecttoFollow;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = objecttoFollow.transform.position + new Vector3(0,0,-10);
    }
}
