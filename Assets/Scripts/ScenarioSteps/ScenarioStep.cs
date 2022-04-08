using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ScenarioStep : MonoBehaviour
{
    [SerializeField] protected PlayerCanvasController playerCanvasController;
    [SerializeField] protected SoundPlayer soundPlayer;

    public UnityAction EndScenarioStepEvent;
    public UnityAction EndActionEvent;

    protected TextHolder textHolder = new TextHolder();
    protected int action;

    public virtual void StartScenarioStep()
    {

    }
    public virtual void StartNextAction()
    {
        action++;
    }
    public virtual void RepeatAction()
    {

    }
    protected IEnumerator WaitTillSoundEnds()
    {
        yield return new WaitForSeconds(soundPlayer.GetSoundLenght());
        EndActionEvent?.Invoke();
    }
}
