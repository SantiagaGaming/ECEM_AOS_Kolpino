using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitScenarioStep : ScenarioStep
{
    [SerializeField] private BrightComplex _brightComplex1;
    [SerializeField] private BrightComplex _brightComplex2;
    [SerializeField] private BrightComplex _brightComplex3;
    protected override void CheckActions(int number)
    {
        
        if (number == 0)
        {
            pitSoundPlayer.Play46Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text46);
            StartCoroutine(WaitTillSoundEnds());
            Player.Instance.CanMove = true;
            talkingManPositionChanger.ChangeToPitPosition();
            teleporter.TeleportToPit();
            canvasPostionChanger.ChangeCanvasPositionToPit();
            _brightComplex1.EnableBright(true);
            _brightComplex2.EnableBright(true);

            ObjectsContainer.Instance.TryGetBaseObject("ybpBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("bkBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright5").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright6").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("rshBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("tshBright").StartAction();
        }
        else if(number ==1)
        {
            pitSoundPlayer.Play47Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text47);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("rshBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("tshBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ybpBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("bkBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright5").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ecBright6").RevertAction();
        }
        else if (number == 2)
        {
            pitSoundPlayer.Play48Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text48);
            StartCoroutine(WaitTillSoundEnds());
            canvasPostionChanger.ChangeCanvasPositionToRschTshPit();
            ObjectsContainer.Instance.TryGetBaseObject("rshBright").StartAction();
        }
        else if (number == 3)
        {
            pitSoundPlayer.Play49Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text49);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("rshBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("tshBright").StartAction();
        }
        else if (number == 4)
        {
            pitSoundPlayer.Play50Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text50);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("tshBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("kbBright").StartAction();
        }
        else if (number == 5)
        {
            pitSoundPlayer.Play51Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text51);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("kbBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("itBright").StartAction();
        }
        else if (number == 6)
        {
            pitSoundPlayer.Play52Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text52);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("itBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("ybpBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("bkBright").StartAction();
            canvasPostionChanger.ChangeCanvasPositionToYbpPit() ;

        }
        else if (number == 7)
        {
            pitSoundPlayer.Play53Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text53);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("ybpBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("bkBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("shvabBright").StartAction();
         
        }
        else if (number == 8)
        {
            pitSoundPlayer.Play54Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text54);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("shvabBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("shvpyBright").StartAction();
            canvasPostionChanger.ChangeCanvasPositionToSbpyPit();
        }

        else if (number == 9)
        {
            pitSoundPlayer.Play56Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text56);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("shvpyBright").RevertAction();
            canvasPostionChanger.ChangeCanvasPositionToRschTshPit();
        }
        else if (number == 10)
        {
            pitSoundPlayer.Play57Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text57);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 11)
        {
            pitSoundPlayer.Play58Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text58);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("abtcBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("abtcBright2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("abtcBright3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("abtcBright4").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("rubBright1").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("rubBright2").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("rubBright3").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("rubBright4").StartAction();
          

        }

        else if (number == 12)
        {
            pitSoundPlayer.Play60Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text60);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 13)
        {
            pitSoundPlayer.Play61Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text61);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("abtcBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("abtcBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("abtcBright3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("abtcBright4").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("rubBright1").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("rubBright2").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("rubBright3").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("rubBright4").RevertAction();
        }
        else if (number == 14)
        {
            pitSoundPlayer.Play62Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text62);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("ybpBright").StartAction();
            ObjectsContainer.Instance.TryGetBaseObject("bkBright").StartAction();
            canvasPostionChanger.ChangeCanvasPositionToYbpPit();

        }
        else if (number == 15)
        {
            pitSoundPlayer.Play63Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text63);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("ybpBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("bkBright").RevertAction();
            canvasPostionChanger.ChangeCanvasPositionToRschTshPit();
        }
        else if (number == 16)
        {
            pitSoundPlayer.Play64Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text64);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("itBright").StartAction();
        }
        else if (number == 17)
        {
            pitSoundPlayer.Play65Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text65);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("itBright").RevertAction();
            ObjectsContainer.Instance.TryGetBaseObject("shvpyBright").StartAction();
            canvasPostionChanger.ChangeCanvasPositionToSbpyPit();
        }

        else if (number == 18)
        {
            pitSoundPlayer.Play67Sound();
            playerCanvasController.SetCanvasText(pitTextHolder.Text67);
            StartCoroutine(WaitTillSoundEnds());
            ObjectsContainer.Instance.TryGetBaseObject("shvpyBright").RevertAction();
        }
        else if(number ==19)
        {
            pitSoundPlayer.StopSoundPlayer();
            EndScenarioStepEvent?.Invoke();
        }

    }
}
