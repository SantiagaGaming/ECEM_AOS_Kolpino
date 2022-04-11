using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ScenarioStep : MonoBehaviour
{
    public UnityAction EndScenarioStepEvent;
    public UnityAction EndActionEvent;

    [SerializeField] protected PlayerCanvasController playerCanvasController;
    [SerializeField] protected SoundPlayer soundPlayer;

    protected TextHolder textHolder = new TextHolder();
    protected int action;

    public  void StartScenarioStep()
    {
        RepeatAction();
    }
    public  void StartNextAction()
    {
        action++;
        CheckActions(action);
    }
    public void RepeatAction()
    {
        CheckActions(action);
    }
   protected virtual void CheckActions(int number)
    {

    }
    protected IEnumerator WaitTillSoundEnds()
    {
        yield return new WaitForSeconds(soundPlayer.GetSoundLenght());
        EndActionEvent?.Invoke();
    }
}
