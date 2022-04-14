using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class YvkScenarioStep4 : ScenarioStep
{
    public UnityAction <bool> ComputerClickEvent;
    [SerializeField] private BaseObject _scpy1;
    [SerializeField] private BaseObject _scpy2;
    [SerializeField] private BaseObject _scpy3;

    [SerializeField] private BaseObject _mip1;
    [SerializeField] private BaseObject _mip2;
    [SerializeField] private BaseObject _mip3;

    [SerializeField] private BaseObject _comp;
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
            _scpy1.StartAction();
        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text206);
            StartCoroutine(WaitTillSoundEnds());
            _scpy1.RevertAction();
            _scpy2.StartAction();
        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
            StartCoroutine(WaitTillSoundEnds());
            _scpy2.RevertAction();
            _scpy3.StartAction();
        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play59Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text59);
            StartCoroutine(WaitTillSoundEnds());
            _scpy3.RevertAction();
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
            _mip1.StartAction();
        }
        else if (number == 10)
        {
            yvkSoundPlayer.Play206Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text206);
            StartCoroutine(WaitTillSoundEnds());
            _mip1.RevertAction();
            _mip2.StartAction();
        }
        else if (number == 11)
        {
            yvkSoundPlayer.Play207Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text207);
            StartCoroutine(WaitTillSoundEnds());
            _mip2.RevertAction();
            _mip3.StartAction();
        }
        else if (number == 12)
        {
            yvkSoundPlayer.Play82Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text82);
            StartCoroutine(WaitTillSoundEnds());
            _mip3.RevertAction();
        }
        else if (number == 13)
        {
            yvkSoundPlayer.Play83Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text83);
            StartCoroutine(WaitTillSoundEnds());
            _comp.StartAction();
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
            yvkSoundPlayer.Play87Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text87);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 18)
        {
            yvkSoundPlayer.Play88Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text88);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 18)
        {
            yvkSoundPlayer.Play88Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text88);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 19)
        {
            yvkSoundPlayer.StopSoundPlayer();
            playerCanvasController.SetCanvasText(yvktextHolder.OpenCompActionText);
            _actionCompButton.SetActive(true);
            ComputerClickEvent?.Invoke(false);
        }
        else if(number ==20)
        {
            ComputerClickEvent?.Invoke(true);
            EndScenarioStepEvent?.Invoke();
        }
    }
 }
