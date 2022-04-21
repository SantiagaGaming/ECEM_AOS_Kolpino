using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleScenarioStep : ScenarioStep
{
    [SerializeField] private TalkingManPositionChanger _talkingManPositionChanger;
    [SerializeField] private CanvasPositionChanger _canvasPostionChanger;
    [SerializeField] private Teleporter _teleporter;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            releSoundPlayer.Play19Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text19);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 1)
        {
            releSoundPlayer.Play20Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text20);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 2)
        {
            releSoundPlayer.Play21Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text21);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 3)
        {
            releSoundPlayer.Play22Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text22);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 4)
        {
            releSoundPlayer.Play23Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text23);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 5)
        {
            releSoundPlayer.Play24Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text24);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 6)
        {
            releSoundPlayer.Play25Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text25);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 7)
        {
            releSoundPlayer.Play26Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text26);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 8)
        {
            releSoundPlayer.Play27Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text27);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 9)
        {
            releSoundPlayer.Play28Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text28);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 10)
        {
            releSoundPlayer.Play29Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text29);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 11)
        {
            releSoundPlayer.Play30Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text30);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 12)
        {
            releSoundPlayer.Play31Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text31);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 13)
        {
            releSoundPlayer.Play32Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text32);
            StartCoroutine(WaitTillSoundEnds());

            _teleporter.TeleportToRele231();
            _talkingManPositionChanger.ChangeToRele231Position();
            _canvasPostionChanger.ChangeCanvasPositionToRele231();
        }
        if (number == 14)
        {
            releSoundPlayer.Play33Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text33);
            StartCoroutine(WaitTillSoundEnds());

            _teleporter.TeleportToRele241();
            _talkingManPositionChanger.ChangeToRele241Position();
            _canvasPostionChanger.ChangeCanvasPositionToRele241();
        }
        if (number == 15)
        {
            releSoundPlayer.Play34Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text34);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 16)
        {
            releSoundPlayer.Play35Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text35);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 17)
        {
            releSoundPlayer.Play36Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text36);
            StartCoroutine(WaitTillSoundEnds());

            _teleporter.TeleportToRele261();
            _talkingManPositionChanger.ChangeToRele261Position();
            _canvasPostionChanger.ChangeCanvasPositionToRele261();
        }
        if (number == 18)
        {
            releSoundPlayer.Play37Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text37);
            StartCoroutine(WaitTillSoundEnds());

            _teleporter.TeleportToRele281();
            _talkingManPositionChanger.ChangeToRele281Position();
            _canvasPostionChanger.ChangeCanvasPositionToRele281();
        }
        if (number == 19)
        {
            releSoundPlayer.Play38Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text38);
            StartCoroutine(WaitTillSoundEnds());
            _talkingManPositionChanger.ChangeToReleDDKPosition();
            _teleporter.TeleportToReleDDK();
            _canvasPostionChanger.ChangeCanvasPositionToReleDDK();
        }
        if (number == 20)
        {
            releSoundPlayer.Play39Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text39);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 21)
        {
            releSoundPlayer.Play40Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text40);
            StartCoroutine(WaitTillSoundEnds());
        }
        if (number == 22)
        {
            _talkingManPositionChanger.ChangeToCrossPosition();
            _teleporter.TeleportToCross();
            _canvasPostionChanger.ChangeCanvasPositionToCross();
            EndScenarioStepEvent?.Invoke();
        }

    }
}
