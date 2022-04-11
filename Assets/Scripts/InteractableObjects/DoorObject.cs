using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorObject : InteractObject
{
    public UnityAction DoorOpenedEvent;
    public override void StartObjectAction()
    {
        StartCoroutine(RotateDoor(true));
    }

    private IEnumerator RotateDoor(bool value)
    {
        if (value)
        {
            ActivateInteraction(false);
            DoorOpenedEvent?.Invoke();
            int y = 0;
            while (y >= -90)
            {
               transform.localRotation = Quaternion.Euler(0, y, 0);
                y--;
                yield return new WaitForSeconds(0.01f);
            }
        }
        //else
        //{
        //    int y = -90;
        //    while (y <= 0)
        //    {
        //        transform.localRotation = Quaternion.Euler(0, y, 0);
        //        y++;
        //        yield return new WaitForSeconds(0.01f);
        //    }

        //}
    }
}
