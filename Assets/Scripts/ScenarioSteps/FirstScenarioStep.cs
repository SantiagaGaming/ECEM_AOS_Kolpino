using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScenarioStep : ScenarioStep
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
        if(number == 0)
        {
            soundPlayer.PlayBeginSound();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number ==1)
        {
            soundPlayer.Play2Sound();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 2)
        {
            soundPlayer.Play3Sound();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 3)
        {
            soundPlayer.Play4Sound();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            soundPlayer.Play5Sound();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 5)
        {
            soundPlayer.Play6Sound();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 6)
        {
            soundPlayer.Play7Sound();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 7)
        {
            soundPlayer.Play8Sound();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 8)
        {
            soundPlayer.Play9Sound();
            StartCoroutine(WaitTillSoundEnds());
        }

    }


}
