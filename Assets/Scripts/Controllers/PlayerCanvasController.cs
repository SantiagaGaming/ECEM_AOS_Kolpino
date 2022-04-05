using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasController : MonoBehaviour
{
    [SerializeField] private PlayerCanvasViev _viev;
    [SerializeField] private ScenarioStepController _scnerioStepsController;
    [SerializeField] private TalkingMan _talkingMan;

    private void OnEnable()
    {
        _viev.TapNextActionButtonEvent += OnStartNextAction;
        _viev.TapRepeatActionButtonEvent += OnRepeatAction;
    }
    private void OnDisable()
    {
        _viev.TapNextActionButtonEvent -= OnStartNextAction;
        _viev.TapRepeatActionButtonEvent -= OnRepeatAction;
    }
    private void OnStartNextAction()
    {
        _scnerioStepsController.GetCurrentScenarioStep().StartNextAction();
        EnableNextActionButton(false);
        _talkingMan.EnableTalking(true);
    }
    private void OnRepeatAction()
    {
        _scnerioStepsController.GetCurrentScenarioStep().RepeatAction();
        EnableNextActionButton(false);
        _talkingMan.EnableTalking(true);
    }
    public void EnableNextActionButton(bool value)
    {
        _viev.EnableActionButtons(value);
        _talkingMan.EnableTalking(!value);
    }

}
