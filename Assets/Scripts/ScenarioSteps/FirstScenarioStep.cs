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
        }
        else if(number ==1)
        {
            soundPlayer.Play2Sound();
         
        }
        else if (number == 2)
        {
            soundPlayer.Play3Sound();
       
        }
        else if (number == 3)
        {
            soundPlayer.Play4Sound();
       
        }
        else if (number == 4)
        {
            soundPlayer.Play5Sound();
        
        }
        else if (number == 5)
        {
            soundPlayer.Play6Sound();
       
        }
        else if (number == 6)
        {
            soundPlayer.Play7Sound();
   
        }
        else if (number == 7)
        {
            soundPlayer.Play8Sound();

        }
        else if (number == 8)
        {
            soundPlayer.Play9Sound();
    
        }

    }


}
