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
        if (number == 10)
        {
            yvkSoundPlayer2.Play106_1Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text106_1);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 11)
        {
            yvkSoundPlayer2.Play106_2Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text106_2);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 12)
        {
            yvkSoundPlayer2.Play106_3Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text106_3);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 13)
        {
            yvkSoundPlayer2.Play106_4Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text106_4);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 14)
        {
            yvkSoundPlayer2.Play107_1Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text107_1);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 15)
        {
            yvkSoundPlayer2.Play107_2Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text107_2);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 16)
        {
            yvkSoundPlayer2.Play107_3Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text107_3);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 17)
        {
            yvkSoundPlayer2.Play147Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text147);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 18)
        {
            yvkSoundPlayer2.Play148Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text148);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 19)
        {
            yvkSoundPlayer2.Play162Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text162);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 20)
        {
            yvkSoundPlayer2.Play170Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text170);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 21)
        {
            yvkSoundPlayer2.Play188Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text188);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 22)
        {
            yvkSoundPlayer2.Play189Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text189);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 23)
        {
            yvkSoundPlayer2.Play193Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text193);
            StartCoroutine(WaitTillSoundEnds());
            //TODO: Close Shkafs
        }
        if (number == 24)
        {
            yvkSoundPlayer2.Play194Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text194);
            StartCoroutine(WaitTillSoundEnds());
        }
    }
}
