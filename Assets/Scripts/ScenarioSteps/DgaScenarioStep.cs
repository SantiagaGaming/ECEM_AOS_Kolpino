using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DgaScenarioStep : ScenarioStep
{
    public UnityAction<bool> EndGameEvent;
    [SerializeField] private GameObject _exitButton;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            dgaSoundPlayer.Play68Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text68);
            StartCoroutine(WaitTillSoundEnds());
            talkingManPositionChanger.ChangeToDgaPosition();
            teleporter.TeleportToDga();
            canvasPostionChanger.ChangeCanvasPositionToDga();
        }
        else if(number ==1)
        {
            dgaSoundPlayer.Play69Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text69);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("glushBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("generatorBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("engineBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("staninaBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("pultBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("pultBright2").StartAction();
        }
        else if (number == 2)
        {
            dgaSoundPlayer.Play70Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text70);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("glushBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("generatorBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("engineBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("staninaBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("pultBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("pultBright2").RevertAction();
        }
        else if (number == 3)
        {
            dgaSoundPlayer.Play71Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text71);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("engineBright").StartAction();
        }
        else if (number == 4)
        {
            dgaSoundPlayer.Play72Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text72);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("engineBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("generatorBright").StartAction();
        }
        else if (number == 5)
        {
            dgaSoundPlayer.Play73Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text73);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("generatorBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("staninaBright").StartAction();
        }
        else if (number == 6)
        {
            dgaSoundPlayer.Play74Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text74);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("staninaBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("glushBright").StartAction();
        }
        else if (number == 7)
        {
            dgaSoundPlayer.Play75Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text75);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("glushBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("pultBright2").StartAction();
            canvasPostionChanger.ChangeCanvasPositionToDgaShield();
        }
        else if (number == 8)
        {
            dgaSoundPlayer.Play76Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text76);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 9)
        {
            dgaSoundPlayer.Play77Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text77);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 10)
        {
            dgaSoundPlayer.Play78Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text78);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 11)
        {
            dgaSoundPlayer.Play79Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text79);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 12)
        {
            dgaSoundPlayer.Play80Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text80);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 13)
        {
            dgaSoundPlayer.Play81Sound();
            playerCanvasController.SetCanvasText(dgaTextHolder.Text81);
            StartCoroutine(WaitTillSoundEnds());
            canvasPostionChanger.ChangeCanvasPositionToDgaEnd();
            ObjectsContainer.Instance.TryGetBaseObject("pultBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("bakBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("bakBright2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("bakBright3").StartAction();
        }
        else if (number == 14)
        {
            playerCanvasController.SetCanvasText(dgaTextHolder.EndText);
            ObjectsContainer.Instance.TryGetBaseObject("bakBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("bakBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("bakBright3").RevertAction();
            _exitButton.SetActive(true);
            EndGameEvent?.Invoke(false);
        }
    }
    }
