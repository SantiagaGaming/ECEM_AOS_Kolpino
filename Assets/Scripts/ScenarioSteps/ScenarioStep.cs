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
