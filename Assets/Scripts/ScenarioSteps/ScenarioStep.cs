using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ScenarioStep : MonoBehaviour
{
    public UnityAction EndScenarioStepEvent;
    public UnityAction EndActionEvent;

    [SerializeField] protected PlayerCanvasController playerCanvasController;
    [SerializeField] protected YvkSoundPlayer yvkSoundPlayer;
    [SerializeField] protected DspSoundPlayer dspSoundPlayer;

    protected YvkTextHolder yvktextHolder = new YvkTextHolder();
    protected DspTextHolder dspTextHolder = new DspTextHolder();
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
        if (dspSoundPlayer.GetSoundLenght()!= 0)
            yield return new WaitForSeconds(dspSoundPlayer.GetSoundLenght());
    else
        yield return new WaitForSeconds(yvkSoundPlayer.GetSoundLenght());
        EndActionEvent?.Invoke();
    }
}
