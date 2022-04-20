using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleScenarioStep : ScenarioStep
{
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            releSoundPlayer.Play19Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text19);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 1)
        {
            releSoundPlayer.Play20Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text20);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 2)
        {
            releSoundPlayer.Play21Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text21);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 3)
        {
            releSoundPlayer.Play22Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text22);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 4)
        {
            releSoundPlayer.Play23Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text23);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 5)
        {
            releSoundPlayer.Play24Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text24);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 6)
        {
            releSoundPlayer.Play25Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text25);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 7)
        {
            releSoundPlayer.Play26Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text26);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 8)
        {
            releSoundPlayer.Play27Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text27);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 9)
        {
            releSoundPlayer.Play28Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text28);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 10)
        {
            releSoundPlayer.Play29Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text29);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 11)
        {
            releSoundPlayer.Play30Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text30);
            StartCoroutine(WaitTillSoundEnds());
        }

    }
}
