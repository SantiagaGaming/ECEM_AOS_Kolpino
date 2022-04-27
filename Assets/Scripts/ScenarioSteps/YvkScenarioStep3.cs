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
            yvkSoundPlayer.Play31Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text31);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play202Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text202);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play205Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text205);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright3").StartAction();
            
        }
        else if (number == 6)
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
        }
        else if (number == 7)
        {
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright1").StartAction();
        }
        else if (number == 8)
        {
            yvkSoundPlayer.Play203Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text203);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("mbkoBodyBright1").RevertAction();
        }
        else if (number == 9)
        {
            yvkSoundPlayer.Play44Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text44);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuBodyBright").StartAction();
        }
        else if(number ==10)
        {
            yvkSoundPlayer.Play45_1Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text45_1);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuBodyBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").StartAction();
        }
        else if(number ==11)
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
        else if(number ==12)
        {
            yvkSoundPlayer.Play46Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text46);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuSwitchBright").StartAction();
        }
        else if(number ==13)
        {
            yvkSoundPlayer.Play47Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text47);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuSwitchBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuCompBright").StartAction();
        }
        else if(number ==14)
        {
            ObjectsContainer.Instance.TryGetBaseObject("cpuCompBright").RevertAction();
            EndScenarioStepEvent?.Invoke();
        }
    }
}