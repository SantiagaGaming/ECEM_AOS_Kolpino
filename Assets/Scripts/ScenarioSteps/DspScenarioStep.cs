using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DspScenarioStep : ScenarioStep
{

    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            talkingManPositionChanger.ChangeToDspPosition();
            canvasPostionChanger.ChangeCanvasPositionToDsp();
            dspSoundPlayer.PlayBeginSound();
            playerCanvasController.SetCanvasText(dspTextHolder.BeginText);
            StartCoroutine(WaitTillSoundEnds());
            Player.Instance.CanMove = false;
        }

        else if (number == 1)
        {
            dspSoundPlayer.Play3Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text3);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("monitorBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("monitorBright2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("monitorBright3").StartAction();
        }
        else if (number == 2)
        {
            dspSoundPlayer.Play5Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text5);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 3)
        {
            dspSoundPlayer.Play8Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text8);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("monitorBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("monitorBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("monitorBright3").RevertAction();
        }
        else if (number == 4)
        {
            dspSoundPlayer.Play9Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text9);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("monitorBigBright").StartAction();
        }
        else if (number == 5)
        {
            dspSoundPlayer.Play10Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text10);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("monitorBigBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBright").StartAction();
        }
        else if (number == 6)
        {
            dspSoundPlayer.Play11Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text11);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 7)
        {
            dspSoundPlayer.Play17Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text17);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 8)
        {
            dspSoundPlayer.Play18Sound();
            playerCanvasController.SetCanvasText(dspTextHolder.Text18);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBright").RevertAction();
        }
        else if (number == 9)
        {
            dspSoundPlayer.StopSoundPlayer();
            EndScenarioStepEvent?.Invoke();
            teleporter.TeleportToYvk();
            talkingManPositionChanger.ChangeToYvkPosition();
            canvasPostionChanger.ChangeCanvasPositionToYvk();
        }

    }
}
