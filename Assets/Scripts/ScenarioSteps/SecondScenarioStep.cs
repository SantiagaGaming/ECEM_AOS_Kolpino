using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondScenarioStep : ScenarioStep
{
    public override void StartScenarioStep()
    {
        RepeatAction();
    }
    public override void StartNextAction()
    {
        base.StartNextAction();
        CheckActions(action);
    }
    public override void RepeatAction()
    {
        CheckActions(action);
    }
    private void CheckActions(int number)
    {
    }
}

