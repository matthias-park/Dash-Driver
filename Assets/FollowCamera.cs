using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // This things position (camera) should be the same position of the car
    // Update is called once per frame
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
