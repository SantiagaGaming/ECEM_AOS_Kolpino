using System.Collections;
using AosSdk.Core.Player;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class YvkScenarioStep3 : ScenarioStep
{
    public UnityAction ShowRepeatButtonEvent;

    [SerializeField] private OpenDoorController _openDoorController;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer.Play24Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text24);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 1)
        {
            playerCanvasController.EnableNextRepeatActionButton(false);
            playerCanvasController.SetCanvasText(yvktextHolder.OpenDoorActionText);
            _openDoorController.EnableDoorsColliders();
        }
        else if (number == 2)
        {
            yvkSoundPlayer.Play28Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text28);
            StartCoroutine(WaitTillSoundEnds());
            teleporter.TeleportToYvk();
            Player.Instance.CanMove = false;
            ShowRepeatButtonEvent?.Invoke();
        }


        else if (number == 3)
        {
            yvkSoundPlayer.Play205Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text205);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright12").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright11").StartAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi7").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi10").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi13").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu7").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu10").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu13").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip1").StartAction();

            

        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text206);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright12").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright11").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi7").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi10").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi13").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu7").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu10").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu13").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip1").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright22").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright21").StartAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi8").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi11").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi14").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu8").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu11").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu14").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip2").StartAction();
        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright22").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright21").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi8").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi11").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi14").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu8").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu11").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu14").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip2").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").StartAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright32").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright31").StartAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi6").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi9").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi12").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi15").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu6").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu9").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu12").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu15").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip3").StartAction();

        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play202Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text202);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").RevertAction();


            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright32").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoBodyPartBright31").RevertAction();

            ObjectsContainer.Instance.TryGetBaseObject("usoSbs3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi6").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi9").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi12").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMsi15").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu6").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu9").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu12").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMvu15").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMip3").RevertAction();



        }
        else if (number == 7)
        {
            yvkSoundPlayer.Play203Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text203);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 8)
        {
            yvkSoundPlayer.Play44Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text44);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuBodyBright").StartAction();
        }
        else if(number ==9)
        {
            yvkSoundPlayer.Play45_1Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text45_1);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuBodyBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").StartAction();
        }
        else if(number ==10)
        {
            yvkSoundPlayer.Play45_2Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text45_2);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").StartAction();
        }
        else if(number ==11)
        {
            yvkSoundPlayer.Play46Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text46);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuSwitchBright").StartAction();
        }
        else if(number ==12)
        {
            yvkSoundPlayer.Play47Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text47);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuSwitchBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuCompBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("computerBright").StartAction();
            
        }
        else if(number ==13)
        {
            ObjectsContainer.Instance.TryGetBaseObject("cpuCompBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("computerBright").RevertAction();
            EndScenarioStepEvent?.Invoke();
        }
    }
}