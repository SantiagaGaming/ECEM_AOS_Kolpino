using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasController : MonoBehaviour
{
    [SerializeField] private PlayerCanvasViev _viev;
    [SerializeField] private ScenarioStepController _scnerioStepsController;
    [SerializeField] private TalkingMan _talkingMan;
    [SerializeField] private OpenDoorController _openDoorController;

    private void OnEnable()
    {
        _viev.TapNextActionButtonEvent += OnStartNextAction;
        _viev.TapRepeatActionButtonEvent += OnRepeatAction;
        _openDoorController.AllDoorsOpenedEvent += OnEbaleCanvas;

    }
    private void OnDisable()
    {
        _viev.TapNextActionButtonEvent -= OnStartNextAction;
        _viev.TapRepeatActionButtonEvent -= OnRepeatAction;
        _openDoorController.AllDoorsOpenedEvent -= OnEbaleCanvas;
    }
    private void OnStartNextAction()
    {
        _scnerioStepsController.GetCurrentScenarioStep().StartNextAction();
      //  EnableNextActionButton(false);
        _talkingMan.EnableTalking(true);
    }
    private void OnRepeatAction()
    {
        _scnerioStepsController.GetCurrentScenarioStep().RepeatAction();
       // EnableNextActionButton(false);
        _talkingMan.EnableTalking(true);
    }
    public void EnableNextRepeatActionButton(bool value)
    {
        _viev.EnableActionButtons(value);
        _talkingMan.EnableTalking(value);
    }
    public void SetCanvasText(string text)
    {
        _viev.ShowText(text);
    }
    public void DisableTalkingMan()
    {
        _talkingMan.EnableTalking(false);
    }
    private void OnEbaleCanvas(bool value)
    {
        _viev.EnableCanvas(value);
    }

}
