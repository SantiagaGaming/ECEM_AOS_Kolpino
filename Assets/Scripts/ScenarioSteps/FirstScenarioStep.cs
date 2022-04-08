using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScenarioStep : ScenarioStep
{
    [SerializeField] private PlayerCanvasController _playerCanvasController;

    private TextHolder _textHolder = new TextHolder();
    public override void StartScenarioStep()
    {
        RepeatAction();
    }
    public override void StartNextAction()
    {
        base.StartNextAction();
        CheckActions(action);
    }
    public override void RepeatAction()
    {
        CheckActions(action);
    }
    private void CheckActions(int number)
    {
        if(number == 0)
        {
            soundPlayer.PlayBeginSound();
            _playerCanvasController.SetCanvasText(_textHolder.BeginText);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number ==1)
        {
            soundPlayer.Play1Sound();
            _playerCanvasController.SetCanvasText(_textHolder.Text1);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 2)
        {
            soundPlayer.Play2Sound();
            _playerCanvasController.SetCanvasText(_textHolder.Text2);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 3)
        {
            soundPlayer.Play3Sound();
            _playerCanvasController.SetCanvasText(_textHolder.Text3);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 4)
        {
            soundPlayer.Play4Sound();
            _playerCanvasController.SetCanvasText(_textHolder.Text4);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 5)
        {
            soundPlayer.Play5Sound();
            _playerCanvasController.SetCanvasText(_textHolder.Text5);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 6)
        {
            soundPlayer.Play6Sound();
            _playerCanvasController.SetCanvasText(_textHolder.Text6);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 7)
        {
            soundPlayer.Play7Sound();
            _playerCanvasController.SetCanvasText(_textHolder.Text7);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 8)
        {
            soundPlayer.Play8Sound();
            _playerCanvasController.SetCanvasText(_textHolder.Text8);
            StartCoroutine(WaitTillSoundEnds());

        }

    }


}
