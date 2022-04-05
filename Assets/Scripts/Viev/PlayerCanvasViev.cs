using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerCanvasViev : MonoBehaviour
{
    public UnityAction TapNextActionButtonEvent;
    public UnityAction TapRepeatActionButtonEvent;

    [SerializeField] private GameObject _nextActionButton;
    [SerializeField] private GameObject _repeatActionButton;


    public void EnableActionButtons(bool value)
    {
        _nextActionButton.SetActive(value);
        _repeatActionButton.SetActive(value);
    }


}
