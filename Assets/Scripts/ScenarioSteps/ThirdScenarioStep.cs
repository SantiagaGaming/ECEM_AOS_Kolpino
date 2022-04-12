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
            soundPlayer.Play24Sound();
            playerCanvasController.SetCanvasText(textHolder.Text24);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 1)
        {
            playerCanvasController.EnableNextRepeatActionButton(false);
            playerCanvasController.SetCanvasText(textHolder.OpenDoorActionText);
            _openDoorController.EnableDoorsColliders();
        }
        else if (number == 2)
        {
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play28Sound();
            playerCanvasController.SetCanvasText(textHolder.Text28);
        }
        else if (number == 3)
        {
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play31Sound();
            playerCanvasController.SetCanvasText(textHolder.Text31);
        }
        else if (number == 4)
        {
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play202Sound();
            playerCanvasController.SetCanvasText(textHolder.Text202);
        }
        else if (number == 5)
        {
            _scpy1.StartAction();
            _mip1.StartAction();
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play205Sound();
            playerCanvasController.SetCanvasText(textHolder.Text205);
        }
        else if (number == 6)
        {
            _scpy1.RevertAction();
            _mip1.RevertAction();
            _scpy2.StartAction();
            _mip2.StartAction();
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(textHolder.Text206);
        }
        else if (number == 7)
        {
            _scpy2.RevertAction();
            _mip2.RevertAction();
            _scpy3.StartAction();
            _mip3.StartAction();
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(textHolder.Text207);
        }
        else if (number == 8)
        {
            _scpy3.RevertAction();
            _mip3.RevertAction();
        }
     }
}