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
            yvkSoundPlayer.Play90_1Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_1);
            StartCoroutine(WaitTillSoundEnds());
            _shkafUCO1.RevertAction();
            _shkafUCO2.RevertAction();
        }
        else if(number==2)
        {
              yvkSoundPlayer.Play90_2Sound();
              playerCanvasController.SetCanvasText(yvktextHolder.Text90_2);
              StartCoroutine(WaitTillSoundEnds());
         }
        else if (number == 3)
        {
            yvkSoundPlayer.Play90_3Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_3);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play90_4Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_4);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play90_5Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_5);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play208Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text208);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 7)
        {
            yvkSoundPlayer.Play209Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text209);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 8)
        {
            yvkSoundPlayer.Play210Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text210);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 9)
        {
            yvkSoundPlayer.Play211Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text211);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 10)
        {
            yvkSoundPlayer.Play212Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text212);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 11)
        {
            yvkSoundPlayer.Play213Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text213);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 12)
        {
            yvkSoundPlayer.Play214Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text214);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 13)
        {
            yvkSoundPlayer.Play215Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text215);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 14)
        {
            yvkSoundPlayer.Play216Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text216);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 15)
        {
            yvkSoundPlayer.Play217Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text217);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 16)
        {
            yvkSoundPlayer.Play218Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text218);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 17)
        {
            yvkSoundPlayer.Play219Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text219);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 18)
        {
            yvkSoundPlayer.Play220Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text220);
            StartCoroutine(WaitTillSoundEnds());
        }

    }
}
