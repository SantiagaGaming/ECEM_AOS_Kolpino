using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Player;
using AosSdk.Core.Interfaces;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform _yvkPosition;
    [SerializeField] private Transform _relePosition221;
    [SerializeField] private Transform _relePosition231;
    [SerializeField] private Transform _relePosition241;
    [SerializeField] private Transform _relePosition261;
    [SerializeField] private Transform _relePosition281;
    [SerializeField] private Transform _relePositionDDK;
    [SerializeField] private Transform _crossPosition;
    [SerializeField] private Transform _pitPosition;
    [SerializeField] private CameraFlash _cameraFlash;

    public void TeleportToYvk()
    {
        Player.Instance.TeleportTo(_yvkPosition);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele221()
    {
        Player.Instance.TeleportTo(_relePosition221);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele231()
    {
        Player.Instance.TeleportTo(_relePosition231);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele241()
    {
        Player.Instance.TeleportTo(_relePosition241);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele261()
    {
        Player.Instance.TeleportTo(_relePosition261);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele281()
    {
        Player.Instance.TeleportTo(_relePosition281);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToReleDDK()
    {
        Player.Instance.TeleportTo(_relePositionDDK);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToCross()
    {
        Player.Instance.TeleportTo(_crossPosition);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToPit()
    {
        Player.Instance.TeleportTo(_pitPosition);
        _cameraFlash.CameraFlashStart();
    }
}

