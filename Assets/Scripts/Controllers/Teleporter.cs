using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Player;
using AosSdk.Core.Interfaces;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private GameObject _vrPlayer;

    [SerializeField] private Transform _yvkPositionD;
    [SerializeField] private Transform _relePosition221D;
    [SerializeField] private Transform _relePosition231D;
    [SerializeField] private Transform _relePosition241D;
    [SerializeField] private Transform _relePosition261D;
    [SerializeField] private Transform _relePosition281D;
    [SerializeField] private Transform _relePositionDDKD;
    [SerializeField] private Transform _crossPositionD;
    [SerializeField] private Transform _pitPositionD;
    [SerializeField] private Transform _dgaPositionD;

    [SerializeField] private Transform _yvkPosition;
    [SerializeField] private Transform _relePosition221;
    [SerializeField] private Transform _relePosition231;
    [SerializeField] private Transform _relePosition241;
    [SerializeField] private Transform _relePosition261;
    [SerializeField] private Transform _relePosition281;
    [SerializeField] private Transform _relePositionDDK;
    [SerializeField] private Transform _crossPosition;
    [SerializeField] private Transform _pitPosition;
    [SerializeField] private Transform _dgaPosition;
    [SerializeField] private CameraFlash _cameraFlash;

    public void TeleportToYvk()
    {
        if(_vrPlayer.activeSelf ==true)
        Player.Instance.TeleportTo(_yvkPosition);
        else
            Player.Instance.TeleportTo(_yvkPositionD);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele221()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_relePosition221);
        else
            Player.Instance.TeleportTo(_relePosition221D);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele231()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_relePosition231);
        else
            Player.Instance.TeleportTo(_relePosition231D);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele241()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_relePosition241);
        else
            Player.Instance.TeleportTo(_relePosition241D);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele261()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_relePosition261);
        else
            Player.Instance.TeleportTo(_relePosition261D);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToRele281()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_relePosition281);
        else
            Player.Instance.TeleportTo(_relePosition281D);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToReleDDK()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_relePositionDDK);
        else
            Player.Instance.TeleportTo(_relePositionDDKD);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToCross()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_crossPosition);
        else
            Player.Instance.TeleportTo(_crossPositionD);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToPit()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_pitPosition);
        else
            Player.Instance.TeleportTo(_pitPositionD);
        _cameraFlash.CameraFlashStart();
    }
    public void TeleportToDga()
    {
        if (_vrPlayer.activeSelf == true)
            Player.Instance.TeleportTo(_dgaPosition);
        else
            Player.Instance.TeleportTo(_dgaPositionD);
        _cameraFlash.CameraFlashStart();
    }
}

