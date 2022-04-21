using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DspScenarioStep : ScenarioStep
{
    [SerializeField] private TalkingManPositionChanger _talkingManPositionChanger;
    [SerializeField] private CanvasPositionChanger _canvasPostionChanger;
    [SerializeField] private Teleporter _teleporter;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            _talkingManPositionChanger.ChangeToDspPosition();
            _canvasPostionChanger.ChangeCanvasPositionToDsp();
            dspSoundPlayer.PlayBeginSound();
            playerCanvasController.SetCanvasText(dspTextHolder.BeginText);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number == 1)
        {
            dspSoundPlayer.Play2Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text2);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 2)
        {
            dspSoundPlayer.Play3Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text3);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 3)
        {
            dspSoundPlayer.Play4Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text4);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            dspSoundPlayer.Play5Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text5);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 5)
        {
            dspSoundPlayer.Play6Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text6);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 6)
        {
            dspSoundPlayer.Play7Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text7);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 7)
        {
            dspSoundPlayer.Play8Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text8);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 8)
        {
            dspSoundPlayer.Play9Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text9);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 9)
        {
            dspSoundPlayer.Play10Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text10);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 10)
        {
            dspSoundPlayer.Play11Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text11);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 11)
        {
            dspSoundPlayer.Play12Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text12);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 12)
        {
            dspSoundPlayer.Play13Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text13);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 13)
        {
            dspSoundPlayer.Play14Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text14);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 14)
        {
            dspSoundPlayer.Play15Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text15);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 15)
        {
            dspSoundPlayer.Play16Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text16);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 16)
        {
            dspSoundPlayer.Play17Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text17);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 17)
        {
            dspSoundPlayer.Play18Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text18);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number ==18)
        {
            dspSoundPlayer.StopSoundPlayer();
            EndScenarioStepEvent?.Invoke();
            _teleporter.TeleportToYvk();
            _talkingManPositionChanger.ChangeToYvkPosition();
            _canvasPostionChanger.ChangeCanvasPositionToYvk();
        }

    }
}
