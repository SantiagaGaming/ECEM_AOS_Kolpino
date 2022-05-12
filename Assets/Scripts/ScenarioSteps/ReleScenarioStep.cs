using AosSdk.Core.Player;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.InputSystem;
public class ReleScenarioStep : ScenarioStep
{

    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer2.StopSoundPlayer();
            releSoundPlayer.Play19Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text19);
            StartCoroutine(WaitTillSoundEnds());
            Player.Instance.CanMove = false;
        }

        else if (number == 1)
        {
            releSoundPlayer.Play22Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text22);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 2)
        {
            releSoundPlayer.Play24Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text24);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 3)
        {
            releSoundPlayer.Play31Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text31);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            releSoundPlayer.Play32Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text32);
            StartCoroutine(WaitTillSoundEnds());
            Player.Instance.CanMove = true;
            teleporter.TeleportToRele231();
            talkingManPositionChanger.ChangeToRele231Position();
            canvasPostionChanger.ChangeCanvasPositionToRele231();
            Player.Instance.CanMove = false;
        }
        else if (number == 5)
        {
          
            releSoundPlayer.Play33Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text33);
            StartCoroutine(WaitTillSoundEnds());
            Player.Instance.CanMove = true;
            teleporter.TeleportToRele241();
            talkingManPositionChanger.ChangeToRele241Position();
            canvasPostionChanger.ChangeCanvasPositionToRele241();
            Player.Instance.CanMove = false;
        }

        else if (number == 6)
        {
            releSoundPlayer.Play36Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text36);
            StartCoroutine(WaitTillSoundEnds());
            Player.Instance.CanMove = true;
            teleporter.TeleportToRele261();
            talkingManPositionChanger.ChangeToRele261Position();
            canvasPostionChanger.ChangeCanvasPositionToRele261();
            Player.Instance.CanMove = false;
        }
        else if (number == 7)
        {
            releSoundPlayer.Play37Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text37);
            StartCoroutine(WaitTillSoundEnds());
            Player.Instance.CanMove = true;
            teleporter.TeleportToRele281();
            talkingManPositionChanger.ChangeToRele281Position();
            canvasPostionChanger.ChangeCanvasPositionToRele281();
            Player.Instance.CanMove = false;

        }
        else if (number == 8)
        {
            releSoundPlayer.Play38Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text38);
            StartCoroutine(WaitTillSoundEnds());
            Player.Instance.CanMove = true;
            talkingManPositionChanger.ChangeToReleDDKPosition();
            teleporter.TeleportToReleDDK();
            canvasPostionChanger.ChangeCanvasPositionToReleDDK();
            Player.Instance.CanMove = false;
        }
        else if (number == 9)
        {
            releSoundPlayer.Play39Sound();
            playerCanvasController.SetCanvasText(releTextHolder.Text39);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 10)
        {
            Player.Instance.CanMove = true;
            talkingManPositionChanger.ChangeToCrossPosition();
            teleporter.TeleportToCross();
            canvasPostionChanger.ChangeCanvasPositionToCross();
            EndScenarioStepEvent?.Invoke();
            releSoundPlayer.StopSoundPlayer();
            Player.Instance.CanMove = false;
        }

    }
}
