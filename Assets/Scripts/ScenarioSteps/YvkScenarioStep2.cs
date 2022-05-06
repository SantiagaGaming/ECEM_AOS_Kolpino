using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkScenarioStep2 : ScenarioStep
{
   protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer.Play201Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text201);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 1)
        {
            yvkSoundPlayer.Play16Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text16);
            ObjectsContainer.Instance.TryGetBaseObject("cpuDoorBright1").StartAction();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 2)
        {
            yvkSoundPlayer.Play17Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text17);
            ObjectsContainer.Instance.TryGetBaseObject("cpuDoorBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ucoDoorBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("ucoDoorBright2").StartAction();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play18Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text18);
            ObjectsContainer.Instance.TryGetBaseObject("ucoDoorBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ucoDoorBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("crossDoorBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("crossDoorBright2").StartAction();
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play19Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text19);
            ObjectsContainer.Instance.TryGetBaseObject("crossDoorBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("crossDoorBright2").RevertAction();
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 5)
        {
            yvkSoundPlayer.Play21Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text21);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("greenLampYvk1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("greenLampYvk2").StartAction();
        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play22Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text22);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 7)
        {
            ObjectsContainer.Instance.TryGetBaseObject("greenLampYvk1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("greenLampYvk2").RevertAction();
            EndScenarioStepEvent();
        }

    }
}


