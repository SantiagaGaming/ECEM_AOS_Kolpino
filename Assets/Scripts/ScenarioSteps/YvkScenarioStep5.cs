using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkScenarioStep5 : ScenarioStep
{
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer.Play89Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text89);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyBright2").StartAction();
        }
        else if (number == 1)
        {
            yvkSoundPlayer.Play90_1Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_1);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyBright2").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi6").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi7").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi8").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi9").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi10").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi11").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi12").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi13").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi14").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi15").StartAction();
        }
        else if (number == 2)
        {
            yvkSoundPlayer.Play90_2Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_2);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi6").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi7").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi8").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi9").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi10").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi11").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi12").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi13").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi14").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi15").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMvu1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu6").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu7").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu8").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu9").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu10").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu11").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu12").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu13").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu14").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu15").StartAction();
        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play90_3Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_3);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu6").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu7").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu8").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu9").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu10").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu11").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu12").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu13").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu14").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu15").RevertAction();


            ObjectsContainer.Instance.TryGetBaseObject("usoMbko1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko6").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko7").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko8").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko9").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko10").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko11").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko12").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko13").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko14").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko15").StartAction();

        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play90_4Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_4);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko6").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko7").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko8").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko9").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko10").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko11").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko12").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko13").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko14").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko15").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs3").StartAction();
        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play90_5Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_5);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs3").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMip1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip3").StartAction();
        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play93Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text93);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoMip1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip3").RevertAction();
        }

        else if (number == 7)
        {
            yvkSoundPlayer.Play208Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text208);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi3").StartAction();

        }
        else if (number == 8)
        {
            yvkSoundPlayer.Play209Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text209);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi3").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi6").StartAction();

        }
        else if (number == 9)
        {
            yvkSoundPlayer.Play210Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text210);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi6").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi7").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi8").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi9").StartAction();
        }
        else if (number == 10)
        {
            yvkSoundPlayer.Play211Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text211);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi7").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi8").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi9").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi10").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi11").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi12").StartAction();
        }
        else if (number == 11)
        {
            yvkSoundPlayer.Play212Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text212);
            StartCoroutine(WaitTillSoundEnds());


            ObjectsContainer.Instance.TryGetBaseObject("usoMsi10").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi11").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi12").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi13").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi14").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi15").StartAction();
        }
        else if (number == 12)
        {
            yvkSoundPlayer.Play215Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text215);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoMsi13").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi14").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi15").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMvu13").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu14").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu15").StartAction();
        }
        else if (number == 13)
        {
            yvkSoundPlayer.Play216Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text216);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu13").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu14").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu15").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMvu10").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu11").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu12").StartAction();
        }
        else if (number == 14)
        {
            yvkSoundPlayer.Play217Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text217);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu10").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu11").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu12").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMvu7").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu8").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu9").StartAction();
        }
        else if (number == 15)
        {
            yvkSoundPlayer.Play218Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text218);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoMvu7").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu8").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu9").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMvu4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu6").StartAction();

        }
        else if (number == 16)
        {
            yvkSoundPlayer.Play219Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text219);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoMvu4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu6").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoMvu1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu3").StartAction();

        }
        else if (number == 17)
        {
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu3").RevertAction();


            yvkSoundPlayer.StopSoundPlayer();
            EndScenarioStepEvent?.Invoke();
        }
    }
}
