using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DgaScenarioStep : ScenarioStep
{
    public UnityAction<bool> EndGameEvent;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            dgaSoundPlayer.Play68Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text68);
            StartCoroutine(WaitTillSoundEnds());
            talkingManPositionChanger.ChangeToDgaPosition();
            teleporter.TeleportToDga();
            canvasPostionChanger.ChangeCanvasPositionToDga();
        }
        else if(number ==1)
        {
            dgaSoundPlayer.Play69Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text69);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 2)
        {
            dgaSoundPlayer.Play70Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text70);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 3)
        {
            dgaSoundPlayer.Play71Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text71);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            dgaSoundPlayer.Play72Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text72);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 5)
        {
            dgaSoundPlayer.Play73Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text73);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 6)
        {
            dgaSoundPlayer.Play74Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text74);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 7)
        {
            dgaSoundPlayer.Play75Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text75);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 8)
        {
            dgaSoundPlayer.Play76Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text76);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 9)
        {
            dgaSoundPlayer.Play77Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text77);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 10)
        {
            dgaSoundPlayer.Play78Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text78);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 11)
        {
            dgaSoundPlayer.Play79Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text79);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 12)
        {
            dgaSoundPlayer.Play80Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text80);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 13)
        {
            dgaSoundPlayer.Play81Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text81);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 14)
        {
            dgaSoundPlayer.Play82Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text82);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 15)
        {
            playerCanvasController.SetCanvasText(dgaTextHolder.EndText);
            EndGameEvent?.Invoke(false);
        }
    }
    }
