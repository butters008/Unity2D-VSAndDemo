using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    //The camera's position should be the same as the car
    void Update() {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
