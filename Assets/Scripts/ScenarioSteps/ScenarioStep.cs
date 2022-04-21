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
    protected ReleSoundPlayer releSoundPlayer;
    protected CrossSoundPlayer crossSoundPlayer;
    protected PitSoundPlayer pitSoundPlayer;
    protected DgaSoundPlayer dgaSoundPlayer;

    protected YvkTextHolder yvktextHolder = new YvkTextHolder();
    protected DspTextHolder dspTextHolder = new DspTextHolder();
    protected YvkTextHolder2 yvkTextHolder2 = new YvkTextHolder2();
    protected ReleTextHolder releTextHolder = new ReleTextHolder();
    protected CrossTextHolder crossTextHolder = new CrossTextHolder();
    protected PitTextHolder pitTextHolder = new PitTextHolder();
    protected DgaTextHolder dgaTextHolder = new DgaTextHolder();

    protected TalkingManPositionChanger talkingManPositionChanger;
    protected CanvasPositionChanger canvasPostionChanger;
    protected Teleporter teleporter;

    protected int action;

    protected void Awake()
    {
        yvkSoundPlayer = FindObjectOfType<YvkSoundPlayer>();
        yvkSoundPlayer2 = FindObjectOfType<YvkSoundPlayer2>();
        dspSoundPlayer = FindObjectOfType<DspSoundPlayer>();
        releSoundPlayer = FindObjectOfType<ReleSoundPlayer>();
        crossSoundPlayer = FindObjectOfType<CrossSoundPlayer>();
        pitSoundPlayer = FindObjectOfType<PitSoundPlayer>();
        dgaSoundPlayer = FindObjectOfType<DgaSoundPlayer>();
        talkingManPositionChanger = FindObjectOfType<TalkingManPositionChanger>();
        canvasPostionChanger = FindObjectOfType<CanvasPositionChanger>();
        teleporter = FindObjectOfType<Teleporter>();

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
        if (dspSoundPlayer.GetSoundLenght() != 0)
            yield return new WaitForSeconds(dspSoundPlayer.GetSoundLenght());
        else if (yvkSoundPlayer.GetSoundLenght() != 0)
            yield return new WaitForSeconds(yvkSoundPlayer.GetSoundLenght());
        else if (yvkSoundPlayer2.GetSoundLenght() != 0)
            yield return new WaitForSeconds(yvkSoundPlayer2.GetSoundLenght());
        else if(releSoundPlayer.GetSoundLenght()!=0)
            yield return new WaitForSeconds(releSoundPlayer.GetSoundLenght());
        else if(crossSoundPlayer.GetSoundLenght()!=0)
            yield return new WaitForSeconds(crossSoundPlayer.GetSoundLenght());
        else if(pitSoundPlayer.GetSoundLenght()!=0)
            yield return new WaitForSeconds(pitSoundPlayer.GetSoundLenght());
        else
            yield return new WaitForSeconds(dgaSoundPlayer.GetSoundLenght());
        EndActionEvent?.Invoke();
    }
}
