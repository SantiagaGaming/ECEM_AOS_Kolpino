using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondScenarioStep : ScenarioStep
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
            soundPlayer.Play201Sound();
            playerCanvasController.SetCanvasText(textHolder.Text201);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 1)
        {
            soundPlayer.Play16Sound();
            playerCanvasController.SetCanvasText(textHolder.Text16);
            _shkafCPU.StartAction();
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 2)
        {
            _shkafCPU.RevertAction();
            soundPlayer.Play17Sound();
            playerCanvasController.SetCanvasText(textHolder.Text17);
            _shkafUCO1.StartAction();
            _shkafUCO2.StartAction();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 3)
        {
            _shkafUCO1.RevertAction();
            _shkafUCO2.RevertAction();
            _shkafCross1.StartAction();
            _shkafCross2.StartAction();
            soundPlayer.Play18Sound();
            playerCanvasController.SetCanvasText(textHolder.Text18);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            _shkafCross1.RevertAction();
            _shkafCross2.RevertAction();
            soundPlayer.Play19Sound();
            playerCanvasController.SetCanvasText(textHolder.Text19);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 5)
        {
            soundPlayer.Play20Sound();
            playerCanvasController.SetCanvasText(textHolder.Text20);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 6)
        {
            soundPlayer.Play21Sound();
            playerCanvasController.SetCanvasText(textHolder.Text21);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 7)
        {
            _lamp1.StartAction();
            _lamp2.StartAction();
            soundPlayer.Play22Sound();
            playerCanvasController.SetCanvasText(textHolder.Text22);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 8)
        {
            _lamp1.RevertAction();
            _lamp2.RevertAction();
            soundPlayer.Play23Sound();
            playerCanvasController.SetCanvasText(textHolder.Text23);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 9)
        {
            EndScenarioStepEvent();
        }

    }
}


