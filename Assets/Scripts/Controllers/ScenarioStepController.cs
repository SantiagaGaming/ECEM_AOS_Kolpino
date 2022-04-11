using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioStepController : MonoBehaviour
{
    [SerializeField] private ScenarioStep[] _scenarioSteps;
    [SerializeField] private PlayerCanvasController _playerCanvasController;


    private int _currentScenarioStep;
    private void Awake()
    {
        foreach (var scenarioStep in _scenarioSteps)
        {
            scenarioStep.EndScenarioStepEvent += OnStartNextScenarioStep;
            scenarioStep.EndActionEvent += OnEndScanarioAction;
        }
    }
    private void Start()
    {
        _scenarioSteps[_currentScenarioStep].StartScenarioStep();
    }
    private void OnStartNextScenarioStep()
    {
        _currentScenarioStep++;
        _scenarioSteps[_currentScenarioStep].StartScenarioStep();
    }
    
    public ScenarioStep GetCurrentScenarioStep()
    {
        return _scenarioSteps[_currentScenarioStep];
    }
    private void OnEndScanarioAction()
    {
        _playerCanvasController.DisableTalkingMan();
    }
}
