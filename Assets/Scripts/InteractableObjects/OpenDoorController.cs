using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenDoorController : MonoBehaviour
{
    public UnityAction <bool>AllDoorsOpenedEvent;
    public UnityAction FirstDoorTappedEvent;
    [SerializeField] private DoorObject[] _doorObjects;

    private int _doors;
    private void Start()
    {
        foreach (var door in _doorObjects)
        {
            door.DoorOpenedEvent += OnDoorOpen;
        }
    }

    public void OnDoorOpen()
    {
        _doors++;
        AllDoorsOpenedEvent?.Invoke(false);
        if (_doors >= 4)
        {
            AllDoorsOpenedEvent?.Invoke(true);
        }
          
    }
    public void EnableDoorsColliders()
    {
        foreach (var door in _doorObjects)
        {
            door.ActivateInteraction(true);
        }
    }

}
