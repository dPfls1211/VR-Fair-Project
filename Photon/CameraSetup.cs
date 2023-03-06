using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Photon.Pun;
using UnityEngine;

public class CameraSetup : MonoBehaviourPun
{
   void Start()
    {
        if(photonView.IsMine)
        {
            CinemachineVirtualCamera followCam = (CinemachineVirtualCamera)FindObjectOfType(typeof(CinemachineVirtualCamera));
            followCam.Follow = transform;
            followCam.LookAt = transform;
        }
    }
}
