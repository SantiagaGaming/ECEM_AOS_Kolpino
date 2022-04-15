using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkScenarioStep6 : ScenarioStep
{
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer2.Play95Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text95);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 1)
        {
            yvkSoundPlayer2.Play97Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text97);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 2)
        {
            yvkSoundPlayer2.Play105_1Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text105_1);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 3)
        {
            yvkSoundPlayer2.Play221Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text221);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 4)
        {
            yvkSoundPlayer2.Play222Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text222);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 5)
        {
            yvkSoundPlayer2.Play223Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text223);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 6)
        {
            yvkSoundPlayer2.Play105_2Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text105_2);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 7)
        {
            yvkSoundPlayer2.Play224Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text224);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 8)
        {
            yvkSoundPlayer2.Play225Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text225);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 9)
        {
            yvkSoundPlayer2.Play226Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text226);
            StartCoroutine(WaitTillSoundEnds());
        }
    }
}
