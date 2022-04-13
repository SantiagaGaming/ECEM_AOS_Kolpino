using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkScenarioStep2 : ScenarioStep
{
    [SerializeField] private BaseObject _shkafCPU;
    [SerializeField] private BaseObject _shkafUCO1;
    [SerializeField] private BaseObject _shkafUCO2;
    [SerializeField] private BaseObject _shkafCross1;
    [SerializeField] private BaseObject _shkafCross2;
    [SerializeField] private BaseObject _lamp1;
    [SerializeField] private BaseObject _lamp2;

   protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer.Play201Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text201);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 1)
        {
            yvkSoundPlayer.Play16Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text16);
            _shkafCPU.StartAction();
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 2)
        {
            yvkSoundPlayer.Play17Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text17);
            _shkafCPU.RevertAction();
            _shkafUCO1.StartAction();
            _shkafUCO2.StartAction();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play18Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text18);
            _shkafUCO1.RevertAction();
            _shkafUCO2.RevertAction();
            _shkafCross1.StartAction();
            _shkafCross2.StartAction();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play19Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text19);
            _shkafCross1.RevertAction();
            _shkafCross2.RevertAction();
             StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play20Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text20);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play21Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text21);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 7)
        {
            yvkSoundPlayer.Play22Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text22);
            _lamp1.StartAction();
            _lamp2.StartAction();
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 8)
        {
            yvkSoundPlayer.Play23Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text23);
            _lamp1.RevertAction();
            _lamp2.RevertAction();
               StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 9)
        {
            EndScenarioStepEvent();
        }

    }
}


