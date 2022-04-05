using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookObject : BaseObject
{
    [SerializeField] private GameObject _noteBook;
    [SerializeField] private GameObject _lid;
    public override void StartAction()
    {
        StartCoroutine(ShowNoteBook(true));
    }

    public override void RevertAction()
    {
        StartCoroutine(ShowNoteBook(false));
    }

    private IEnumerator ShowNoteBook(bool value)
    {
        canAction = false;
        if (value)
        {
            int z = 0;
                while (z<=35)
            {
                _noteBook.transform.localPosition += new Vector3(0, 0, 0.01f);
                z++;
                yield return new WaitForSeconds(0.01f);
            }
            int x = 95;
            while (x >= 0)
            {
                _lid.transform.localRotation = Quaternion.Euler(x,0 , 0);
                x--;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            int x = 0;
            while (x <= 95)
            {
                _lid.transform.localRotation = Quaternion.Euler(x, 0, 0);
                x++;
                yield return new WaitForSeconds(0.01f);
            }
            int z = 35;
            while (z >= 0)
            {
                _noteBook.transform.localPosition -= new Vector3(0, 0, 0.01f);
                z--;
                yield return new WaitForSeconds(0.01f);
            }
  
        }
        canAction = true;
    }

}
