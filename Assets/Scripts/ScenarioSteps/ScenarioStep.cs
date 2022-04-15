using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ScenarioStep : MonoBehaviour
{
    public UnityAction EndScenarioStepEvent;
    public UnityAction EndActionEvent;

    [SerializeField] protected PlayerCanvasController playerCanvasController;
    protected YvkSoundPlayer yvkSoundPlayer;
    protected YvkSoundPlayer2 yvkSoundPlayer2;
    protected DspSoundPlayer dspSoundPlayer;

    protected YvkTextHolder yvktextHolder = new YvkTextHolder();
    protected DspTextHolder dspTextHolder = new DspTextHolder();
    protected YvkTextHolder2 yvkTextHolder2 = new YvkTextHolder2();
    protected int action;

    protected void Awake()
    {
        yvkSoundPlayer = FindObjectOfType<YvkSoundPlayer>();
        yvkSoundPlayer2 = FindObjectOfType<YvkSoundPlayer2>();
        dspSoundPlayer = FindObjectOfType<DspSoundPlayer>();

    }
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
    else if(yvkSoundPlayer.GetSoundLenght()!=0)
        yield return new WaitForSeconds(yvkSoundPlayer.GetSoundLenght());
        else
            yield return new WaitForSeconds(yvkSoundPlayer2.GetSoundLenght());
        EndActionEvent?.Invoke();
    }
}
