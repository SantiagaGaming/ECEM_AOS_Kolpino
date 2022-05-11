using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class YvkScenarioStep4 : ScenarioStep
{
    public UnityAction <bool> ComputerClickEvent;
    [SerializeField] private GameObject _actionCompButton;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer.Play204Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text204);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 1)
        {
            yvkSoundPlayer.Play58Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text58);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 2)
        {
            yvkSoundPlayer.Play205Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text205);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").StartAction();
        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text206);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").StartAction();
        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").StartAction();
        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play59Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text59);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("scpu3Bright").RevertAction();
        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play60Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text60);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 7)
        {
            yvkSoundPlayer.Play63Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text63);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 8)
        {
            yvkSoundPlayer.Play74Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text74);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 9)
        {
            yvkSoundPlayer.Play205Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text205);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").StartAction();
        }
        else if (number == 10)
        {
            yvkSoundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text206);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip1Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").StartAction();
        }
        else if (number == 11)
        {
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip2Bright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").StartAction();
        }
        else if (number == 12)
        {
            yvkSoundPlayer.Play82Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text82);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuMip3Bright").RevertAction();
        }
        else if (number == 13)
        {
            yvkSoundPlayer.Play83Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text83);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("cpuCompBright").StartAction();
        }
        else if (number == 14)
        {
            yvkSoundPlayer.Play84Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text84);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 15)
        {
            yvkSoundPlayer.StopSoundPlayer();
            playerCanvasController.SetCanvasText(yvktextHolder.OpenCompActionText);
            _actionCompButton.SetActive(true);
            ComputerClickEvent?.Invoke(false);
        }
        else if(number == 16)
        {
            yvkSoundPlayer.Play85Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text85);
            StartCoroutine(WaitTillSoundEnds());
            ComputerClickEvent?.Invoke(true);
        }

        else if (number == 17)
        {
            yvkSoundPlayer.Play88Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text88);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 18)
        {
            yvkSoundPlayer.StopSoundPlayer();
            playerCanvasController.SetCanvasText(yvktextHolder.OpenCompActionText);
            _actionCompButton.SetActive(true);
            ComputerClickEvent?.Invoke(false);
        }
        else if(number == 19)
        {
            ObjectsContainer.Instance.TryGetBaseObject("cpuCompBright").RevertAction();
            ComputerClickEvent?.Invoke(true);
            EndScenarioStepEvent?.Invoke();
        }
    }
 }
