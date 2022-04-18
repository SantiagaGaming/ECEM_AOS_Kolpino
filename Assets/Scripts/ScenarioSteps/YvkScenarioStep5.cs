using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkScenarioStep5 : ScenarioStep
{
    [SerializeField] private BaseObject _shkafUCO1;
    [SerializeField] private BaseObject _shkafUCO2;

    [SerializeField] private BaseObject _msi1;
    [SerializeField] private BaseObject _msi2;
    [SerializeField] private BaseObject _msi3;
    [SerializeField] private BaseObject _msi4;

    [SerializeField] private BaseObject _mvu1;
    [SerializeField] private BaseObject _mvu2;
    [SerializeField] private BaseObject _mvu3;

    [SerializeField] private BaseObject _mbko1;
    [SerializeField] private BaseObject _mbko2;

    [SerializeField] private BaseObject _sbs1;
    [SerializeField] private BaseObject _sbs2;
    [SerializeField] private BaseObject _sbs3;

    [SerializeField] private BaseObject _mip1;
    [SerializeField] private BaseObject _mip2;
    [SerializeField] private BaseObject _mip3;

    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            yvkSoundPlayer.Play89Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text89);
            StartCoroutine(WaitTillSoundEnds());
            _shkafUCO1.StartAction();
            _shkafUCO2.StartAction();
        }
        else if(number==1)
        {
            yvkSoundPlayer.Play90_1Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_1);
            StartCoroutine(WaitTillSoundEnds());
            _shkafUCO1.RevertAction();
            _shkafUCO2.RevertAction();
            _msi1.StartAction();
            _msi2.StartAction();
            _msi3.StartAction();
            _msi4.StartAction();
        }
        else if(number==2)
        {
              yvkSoundPlayer.Play90_2Sound();
              playerCanvasController.SetCanvasText(yvktextHolder.Text90_2);
              StartCoroutine(WaitTillSoundEnds());
            _msi1.RevertAction();
            _msi2.RevertAction();
            _msi3.RevertAction();
            _msi4.RevertAction();
            _mvu1.StartAction();
            _mvu2.StartAction();
            _mvu3.StartAction();
        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play90_3Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_3);
            StartCoroutine(WaitTillSoundEnds());
            _mvu1.RevertAction();
            _mvu2.RevertAction();
            _mvu3.RevertAction();
            _mbko1.StartAction();
            _mbko2.StartAction();
        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play90_4Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_4);
            StartCoroutine(WaitTillSoundEnds());
            _mbko1.RevertAction();
            _mbko2.RevertAction();
            _sbs1.StartAction();
            _sbs2.StartAction();
            _sbs3.StartAction();

        }
        else if (number == 5)
        {
            yvkSoundPlayer.Play90_5Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_5);
            StartCoroutine(WaitTillSoundEnds());
            _sbs1.RevertAction();
            _sbs2.RevertAction();
            _sbs3.RevertAction();
            _mip1.StartAction();
            _mip2.StartAction();
            _mip3.StartAction();
        }
        else if (number == 6)
        {
            yvkSoundPlayer.Play208Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text208);
            StartCoroutine(WaitTillSoundEnds());
            _mip1.RevertAction();
            _mip2.RevertAction();
            _mip3.RevertAction();
        }
        else if (number == 7)
        {
            yvkSoundPlayer.Play209Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text209);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 8)
        {
            yvkSoundPlayer.Play210Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text210);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 9)
        {
            yvkSoundPlayer.Play211Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text211);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 10)
        {
            yvkSoundPlayer.Play212Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text212);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 11)
        {
            yvkSoundPlayer.Play213Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text213);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 12)
        {
            yvkSoundPlayer.Play214Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text214);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 13)
        {
            yvkSoundPlayer.Play215Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text215);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 14)
        {
            yvkSoundPlayer.Play216Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text216);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 15)
        {
            yvkSoundPlayer.Play217Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text217);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 16)
        {
            yvkSoundPlayer.Play218Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text218);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 17)
        {
            yvkSoundPlayer.Play219Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text219);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 18)
        {
            yvkSoundPlayer.Play220Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text220);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number ==19)
        {
            yvkSoundPlayer.StopSoundPlayer();
            EndScenarioStepEvent?.Invoke();
        }

    }
}
