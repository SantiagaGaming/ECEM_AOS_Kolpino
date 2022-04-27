using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampBlinkController : MonoBehaviour
{
    [SerializeField] private LampBlinker[] _lamps;
    public void StartBlink()
    {
        foreach (var item in _lamps)
        {
            item.EnableBlink(true);
        }
    }
    public void StopBlink()
    {
        foreach (var item in _lamps)
        {
            item.EnableBlink(false);
        }
    }
}
