using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Player;
using AosSdk.Core.Interfaces;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform _yvkPosition;
    [SerializeField] private CameraFlash _cameraFlash;

    public void TeleportToYvk()
    {
        Player.Instance.TeleportTo(_yvkPosition);
        _cameraFlash.CameraFlashStart();
    }
}

