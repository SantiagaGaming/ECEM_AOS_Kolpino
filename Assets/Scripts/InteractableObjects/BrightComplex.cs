using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightComplex : MonoBehaviour
{
    [SerializeField] private BrightObject[] _brightObjects;

    public void EnableBright(bool value)
    {
   
            foreach (var item in _brightObjects)
        {
            if (value)
                item.StartAction();
            else
                item.RevertAction();
        }
  
    }
}
