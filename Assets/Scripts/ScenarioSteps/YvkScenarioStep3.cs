using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class YvkScenarioStep3 : ScenarioStep
{
    public UnityAction ShowRepeatButtonEvent;

    [SerializeField] private OpenDoorController _openDoorController;
    [SerializeField] private BaseObject _shkafCPU;

    [SerializeField] private BaseObject _scpy1;
    [SerializeField] private BaseObject _scpy2;
    [SerializeField] private BaseObject _scpy3;

    [SerializeField] private BaseObject _mip1;
    [SerializeField] private BaseObject _mip2;
    [SerializeField] private BaseObject _mip3;
    [SerializeField] private BaseObject _switch;
    [SerializeField] private BaseObject _comp;
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
            ShowRepeatButtonEvent?.Invoke();
        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play31Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text31);
            StartCoroutine(WaitTillSoundEnds());
            ShowRepeatButtonEvent?.Invoke();
        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play202Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text202);
            StartCoroutine(WaitTillSoundEnds());
            ShowRepeatButtonEvent?.Invoke();
        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play205Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text205);
            StartCoroutine(WaitTillSoundEnds());
            _scpy1.StartAction();
            _mip1.StartAction();
            ShowRepeatButtonEvent?.Invoke();
        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text206);
            StartCoroutine(WaitTillSoundEnds());
            _scpy1.RevertAction();
            _mip1.RevertAction();
            _scpy2.StartAction();
            _mip2.StartAction();
            ShowRepeatButtonEvent?.Invoke();
        }
        else if (number == 7)
        {
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
            StartCoroutine(WaitTillSoundEnds());
            _scpy2.RevertAction();
            _mip2.RevertAction();
            _scpy3.StartAction();
            _mip3.StartAction();
            ShowRepeatButtonEvent?.Invoke();
        }
        else if (number == 8)
        {
            yvkSoundPlayer.Play203Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text203);
            StartCoroutine(WaitTillSoundEnds());
            _scpy3.RevertAction();
            _mip3.RevertAction();
        }
        else if (number == 9)
        {
            yvkSoundPlayer.Play44Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text44);
            StartCoroutine(WaitTillSoundEnds());
            _shkafCPU.StartAction();
        }
        else if(number ==10)
        {
            yvkSoundPlayer.Play45_1Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text45_1);
            StartCoroutine(WaitTillSoundEnds());
            _shkafCPU.RevertAction();
            _scpy1.StartAction();
            _scpy2.StartAction();
            _scpy3.StartAction();
        }
        else if(number ==11)
        {
            yvkSoundPlayer.Play45_2Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text45_2);
            StartCoroutine(WaitTillSoundEnds());
            _scpy1.RevertAction();
            _scpy2.RevertAction();
            _scpy3.RevertAction();
            _mip1.StartAction();
            _mip2.StartAction();
            _mip3.StartAction();

        }
        else if(number ==12)
        {
            yvkSoundPlayer.Play46Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text46);
            StartCoroutine(WaitTillSoundEnds());
            _mip1.RevertAction();
            _mip2.RevertAction();
            _mip3.RevertAction();
            _switch.StartAction();
        }
        else if(number ==13)
        {
            yvkSoundPlayer.Play47Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text47);
            StartCoroutine(WaitTillSoundEnds());
            _switch.RevertAction();
            _comp.StartAction();
        }
        else if(number ==14)
        {
            _comp.RevertAction();
            EndScenarioStepEvent?.Invoke();
        }
    }
}