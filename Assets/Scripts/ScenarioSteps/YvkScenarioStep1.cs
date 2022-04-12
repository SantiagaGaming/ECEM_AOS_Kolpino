using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkScenarioStep1 : ScenarioStep
{

protected override void CheckActions(int number)
    {
        if(number == 0)
        {

            yvkSoundPlayer.PlayBeginSound();
            playerCanvasController.SetCanvasText(yvktextHolder.BeginText);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number ==1)
        {
            yvkSoundPlayer.Play1Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text1);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 2)
        {
            yvkSoundPlayer.Play2Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text2);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play3Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text3);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play4Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text4);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play5Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text5);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play6Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text6);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 7)
        {
            yvkSoundPlayer.Play7Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text7);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 8)
        {
            yvkSoundPlayer.Play8Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text8);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if(number == 9)
        {
            EndScenarioStepEvent?.Invoke();
        }     
    }
}
