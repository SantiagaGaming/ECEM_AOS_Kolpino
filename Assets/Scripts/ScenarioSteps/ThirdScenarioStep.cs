using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThirdScenarioStep : ScenarioStep
{
    public UnityAction ShowRepeatButtonEvent;

    [SerializeField] private OpenDoorController _openDoorController;

    [SerializeField] private BaseObject _scpy1;
    [SerializeField] private BaseObject _scpy2;
    [SerializeField] private BaseObject _scpy3;

    [SerializeField] private BaseObject _mip1;
    [SerializeField] private BaseObject _mip2;
    [SerializeField] private BaseObject _mip3;
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
            ShowRepeatButtonEvent?.Invoke();
            yvkSoundPlayer.Play28Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text28);
        }
        else if (number == 3)
        {
            ShowRepeatButtonEvent?.Invoke();
            yvkSoundPlayer.Play31Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text31);
        }
        else if (number == 4)
        {
            ShowRepeatButtonEvent?.Invoke();
            yvkSoundPlayer.Play202Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text202);
        }
        else if (number == 5)
        {
            _scpy1.StartAction();
            _mip1.StartAction();
            ShowRepeatButtonEvent?.Invoke();
            yvkSoundPlayer.Play205Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text205);
        }
        else if (number == 6)
        {
            _scpy1.RevertAction();
            _mip1.RevertAction();
            _scpy2.StartAction();
            _mip2.StartAction();
            ShowRepeatButtonEvent?.Invoke();
            yvkSoundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text206);
        }
        else if (number == 7)
        {
            _scpy2.RevertAction();
            _mip2.RevertAction();
            _scpy3.StartAction();
            _mip3.StartAction();
            ShowRepeatButtonEvent?.Invoke();
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
        }
        else if (number == 8)
        {
            _scpy3.RevertAction();
            _mip3.RevertAction();
            yvkSoundPlayer.Play203Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text203);
        }
     }
}