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
    [SerializeField] private BaseObject _msi5;
    [SerializeField] private BaseObject _msi6;
    [SerializeField] private BaseObject _msi7;
    [SerializeField] private BaseObject _msi8;
    [SerializeField] private BaseObject _msi9;
    [SerializeField] private BaseObject _msi10;
    [SerializeField] private BaseObject _msi11;
    [SerializeField] private BaseObject _msi12;
    [SerializeField] private BaseObject _msi13;
    [SerializeField] private BaseObject _msi14;
    [SerializeField] private BaseObject _msi15;


    [SerializeField] private BaseObject _mvu1;
    [SerializeField] private BaseObject _mvu2;
    [SerializeField] private BaseObject _mvu3;
    [SerializeField] private BaseObject _mvu4;
    [SerializeField] private BaseObject _mvu5;
    [SerializeField] private BaseObject _mvu6;
    [SerializeField] private BaseObject _mvu7;
    [SerializeField] private BaseObject _mvu8;
    [SerializeField] private BaseObject _mvu9;
    [SerializeField] private BaseObject _mvu10;
    [SerializeField] private BaseObject _mvu11;
    [SerializeField] private BaseObject _mvu12;
    [SerializeField] private BaseObject _mvu13;
    [SerializeField] private BaseObject _mvu14;
    [SerializeField] private BaseObject _mvu15;


    [SerializeField] private BaseObject _mbko1;
    [SerializeField] private BaseObject _mbko2;
    [SerializeField] private BaseObject _mbko3;
    [SerializeField] private BaseObject _mbko4;
    [SerializeField] private BaseObject _mbko5;
    [SerializeField] private BaseObject _mbko6;
    [SerializeField] private BaseObject _mbko7;
    [SerializeField] private BaseObject _mbko8;
    [SerializeField] private BaseObject _mbko9;
    [SerializeField] private BaseObject _mbko10;
    [SerializeField] private BaseObject _mbko11;
    [SerializeField] private BaseObject _mbko12;
    [SerializeField] private BaseObject _mbko13;
    [SerializeField] private BaseObject _mbko14;
    [SerializeField] private BaseObject _mbko15;


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
            _msi5.StartAction();
            _msi6.StartAction();
            _msi7.StartAction();
            _msi8.StartAction();
            _msi9.StartAction();
            _msi10.StartAction();
            _msi11.StartAction();
            _msi12.StartAction();
            _msi13.StartAction();
            _msi14.StartAction();
            _msi15.StartAction();
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
            _msi4.RevertAction();
            _msi5.RevertAction();
            _msi6.RevertAction();
            _msi7.RevertAction();
            _msi8.RevertAction();
            _msi9.RevertAction();
            _msi10.RevertAction();
            _msi11.RevertAction();
            _msi12.RevertAction();
            _msi13.RevertAction();
            _msi14.RevertAction();
            _msi15.RevertAction();

            _mvu1.StartAction();
            _mvu2.StartAction();
            _mvu3.StartAction();
            _mvu4.StartAction();
            _mvu5.StartAction();
            _mvu6.StartAction();
            _mvu7.StartAction();
            _mvu8.StartAction();
            _mvu9.StartAction();
            _mvu10.StartAction();
            _mvu11.StartAction();
            _mvu12.StartAction();
            _mvu13.StartAction();
            _mvu14.StartAction();
            _mvu15.StartAction();

        }
        else if (number == 3)
        {
            yvkSoundPlayer.Play90_3Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_3);
            StartCoroutine(WaitTillSoundEnds());
            _mvu1.RevertAction();
            _mvu2.RevertAction();
            _mvu3.RevertAction();
            _mvu4.RevertAction();
            _mvu5.RevertAction();
            _mvu6.RevertAction();
            _mvu7.RevertAction();
            _mvu8.RevertAction();
            _mvu9.RevertAction();
            _mvu10.RevertAction();
            _mvu11.RevertAction();
            _mvu12.RevertAction();
            _mvu13.RevertAction();
            _mvu14.RevertAction();
            _mvu15.RevertAction();

            _mbko1.StartAction();
            _mbko2.StartAction();
            _mbko3.StartAction();
            _mbko4.StartAction();
            _mbko5.StartAction();
            _mbko6.StartAction();
            _mbko7.StartAction();
            _mbko8.StartAction();
            _mbko9.StartAction();
            _mbko10.StartAction();
            _mbko11.StartAction();
            _mbko12.StartAction();
            _mbko13.StartAction();
            _mbko14.StartAction();
            _mbko15.StartAction();

        }
        else if (number == 4)
        {
            yvkSoundPlayer.Play90_4Sound();
            playerCanvasController.SetCanvasText(yvktextHolder.Text90_4);
            StartCoroutine(WaitTillSoundEnds());
            _mbko1.RevertAction();
            _mbko2.RevertAction();
            _mbko3.RevertAction();
            _mbko4.RevertAction();
            _mbko5.RevertAction();
            _mbko6.RevertAction();
            _mbko7.RevertAction();
            _mbko8.RevertAction();
            _mbko9.RevertAction();
            _mbko10.RevertAction();
            _mbko11.RevertAction();
            _mbko12.RevertAction();
            _mbko13.RevertAction();
            _mbko14.RevertAction();
            _mbko15.RevertAction();

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
