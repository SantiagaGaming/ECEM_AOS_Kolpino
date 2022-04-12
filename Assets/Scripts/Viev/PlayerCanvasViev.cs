using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerCanvasViev : MonoBehaviour
{
    public UnityAction TapNextActionButtonEvent;
    public UnityAction TapRepeatActionButtonEvent;

    [SerializeField] private GameObject _nextActionButton;
    [SerializeField] private GameObject _repeatActionButton;
    [SerializeField] private TextMeshPro _textToShowInCanvas;
    [SerializeField] private GameObject _canvas;


    public void EnableActionButtons(bool value)
    {
        _nextActionButton.SetActive(value);
        _repeatActionButton.SetActive(value);
    }
    public void ShowText(string text)
    {
        _textToShowInCanvas.text = text;
    }
    public void EnableCanvas(bool value)
    {
        _canvas.SetActive(value);
        _nextActionButton.SetActive(value);
        _repeatActionButton.SetActive(value);
    }
    public void EnableRepeatButton(bool value)
    {
        _repeatActionButton.SetActive(value);
    }


}
