using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class YvkScenarioStep6 : ScenarioStep
{
    public UnityAction ShowRepeatButtonEvent;

    [SerializeField] private OpenDoorController _openDoorController;

    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer2.Play95Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text95);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 1)
        {
            yvkSoundPlayer2.Play97Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text97);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 2)
        {
            yvkSoundPlayer2.Play105_1Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text105_1);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 3)
        {
            yvkSoundPlayer2.Play221Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text221);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright1").StartAction();
        }
        else if (number == 4)
        {
            yvkSoundPlayer2.Play222Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text222);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright2").StartAction();
        }
        else if (number == 5)
        {
            yvkSoundPlayer2.Play223Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text223);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright3").StartAction();
        }
        else if (number == 6)
        {
            yvkSoundPlayer2.Play105_2Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text105_2);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright3").RevertAction();

        }
        else if (number == 7)
        {
            yvkSoundPlayer2.Play224Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text224);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright1").StartAction();
        }
        else if (number == 8)
        {
            yvkSoundPlayer2.Play225Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text225);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright2").StartAction();
        }
        else if (number == 9)
        {
            yvkSoundPlayer2.Play226Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text226);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright3").StartAction();

        }
        else if (number == 10)
        {
            yvkSoundPlayer2.Play106_1Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text106_1);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright3").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs3").StartAction();
        }
        else if (number == 11)
        {
            yvkSoundPlayer2.Play106_2Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text106_2);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs3").RevertAction();

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
        else if (number == 12)
        {
            yvkSoundPlayer2.Play106_3Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text106_3);
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
        else if (number == 13)
        {
            yvkSoundPlayer2.Play106_4Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text106_4);
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

            ObjectsContainer.Instance.TryGetBaseObject("usoMip1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip3").StartAction();
        }
        else if (number == 14)
        {
            yvkSoundPlayer2.Play107_1Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text107_1);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs3").StartAction();

        }
        else if (number == 15)
        {
            yvkSoundPlayer2.Play107_2Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text107_2);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("usoMip1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip3").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoSbs3").RevertAction();

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
        else if (number == 16)
        {
            yvkSoundPlayer2.Play107_3Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text107_3);
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
        else if (number == 17)
        {
            yvkSoundPlayer2.Play147Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text147);
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
        }
        else if (number == 18)
        {
            yvkSoundPlayer2.Play148Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text148);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 19)
        {
            yvkSoundPlayer2.Play162Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text162);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 20)
        {
            yvkSoundPlayer2.Play170Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text170);
            StartCoroutine(WaitTillSoundEnds());

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
        else if (number == 21)
        {
            yvkSoundPlayer2.Play188Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text188);
            StartCoroutine(WaitTillSoundEnds());

            ObjectsContainer.Instance.TryGetBaseObject("crossBright1").StartAction();

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
        }
        else if (number == 22)
        {
            yvkSoundPlayer2.Play189Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text189);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("crossBright1").RevertAction();
        }
        else if (number == 23)
        {
            yvkSoundPlayer2.Play193Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text193);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 24)
        {
            playerCanvasController.SetCanvasText(yvkTextHolder2.CloseDoorActionText);
            _openDoorController.EnableDoorsColliders();
            playerCanvasController.EnableNextRepeatActionButton(false);
        }

        else if (number == 25)
        {
            yvkSoundPlayer2.Play194Sound();
            playerCanvasController.SetCanvasText(yvkTextHolder2.Text194);
            StartCoroutine(WaitTillSoundEnds());
            ShowRepeatButtonEvent?.Invoke();
            
        }
        else if(number ==26)
        {
                dspSoundPlayer.StopSoundPlayer();
                teleporter.TeleportToRele221();
                talkingManPositionChanger.ChangeToRele221Position();
                canvasPostionChanger.ChangeCanvasPositionToRele221();
                EndScenarioStepEvent?.Invoke();
        }
    }
}
