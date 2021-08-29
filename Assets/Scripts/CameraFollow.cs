using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    private CinemachineVirtualCamera vcam;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        vcam = GetComponent<CinemachineVirtualCamera>();
        if (player != null)
        {
            vcam.Follow = player.transform;
        }
        else
        {
            Debug.Log(GameObject.FindWithTag("Player"));
            Debug.LogWarning("No player for camera to follow");
        }
    }

}
