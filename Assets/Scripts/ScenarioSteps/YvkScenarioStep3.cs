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
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright3").StartAction();

        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text206);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko6").StartAction();
        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("usoMbko6").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright1").StartAction();
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
        else if (number == 6)
        {
            yvkSoundPlayer.Play202Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text202);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright1").RevertAction();
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