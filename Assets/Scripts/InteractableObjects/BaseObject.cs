using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObject : MonoBehaviour
{
    protected bool action = true;
    protected bool canAction = true;

    [SerializeField] private string _name;

    public virtual void StartAction()
    {

    }
    public virtual void RevertAction()
    {

    }
    public void Action()
    {
        if (canAction)
        {
            if (action)
            {
                action = false;
                StartAction();

            }
            else
            {
                action = true;
                RevertAction();
            }
        }
    }
    public string GetBaseObjectName()
    {
        return _name;
    }
}
