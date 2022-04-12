using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorObject : InteractObject
{
    public UnityAction DoorOpenedEvent;

    [SerializeField] private GameObject _key;
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
            _key.SetActive(true);
         
                _key.SetActive(true);
                int keyX = 0;
                while (keyX < 40)
                {
                    _key.transform.localPosition -= new Vector3(0, 0, 0.00001f);
                    keyX++;
                    yield return new WaitForSeconds(0.005f);
                }
                int keyXRot = -90;
                while (keyXRot < 0)
                {
                    _key.transform.localRotation = Quaternion.Euler(keyXRot, 270, 0);
                    keyXRot++;
                    yield return new WaitForSeconds(0.01f);
                }

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
        //int keyXRot = 90;
        //while (keyXRot > 0)
        //{
        //    _key.transform.localRotation = Quaternion.Euler(keyXRot, 270, 0);
        //    keyXRot--;
        //    yield return new WaitForSeconds(0.01f);
        //}
        //int keyX = 40;
        //while (keyX > 0)
        //{
        //    _key.transform.localPosition += new Vector3(0, 0, 0.00001f);
        //    keyX--;
        //    yield return new WaitForSeconds(0.01f);
        //}
        //_key.SetActive(false);
    }
}
