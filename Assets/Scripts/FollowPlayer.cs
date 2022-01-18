using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player = null;
    private CinemachineVirtualCamera vcam;

    // Start is called before the first frame update
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        player = GameObject.FindWithTag("Player");
        vcam.LookAt = player.transform;
        vcam.Follow = player.transform;
    }
}
