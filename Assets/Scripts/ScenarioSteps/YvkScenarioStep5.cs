using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkScenarioStep5 : ScenarioStep
{
    [SerializeField] private BaseObject _shkafUCO1;
    [SerializeField] private BaseObject _shkafUCO2;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer.Play89Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text89);
            StartCoroutine(WaitTillSoundEnds());
            _shkafUCO1.StartAction();
            _shkafUCO2.StartAction();
        }
        else if(number==1)
        {
            _shkafUCO1.RevertAction();
            _shkafUCO2.RevertAction();
        }

    }
}
