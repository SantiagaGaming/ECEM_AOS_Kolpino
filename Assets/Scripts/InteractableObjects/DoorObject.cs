using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorObject : InteractObject
{
    private bool _turn = true;
    public UnityAction DoorOpenedEvent;

    [SerializeField] private GameObject _key;
    public override void StartObjectAction()
    {
        StartCoroutine(RotateDoor());
    }

    private IEnumerator RotateDoor()
    {
        int keyX;
        int keyXRot;
        int y;
        DoorOpenedEvent?.Invoke();
        if (_turn)
        {
            ActivateInteraction(false);
  
            _key.SetActive(true);
         
                _key.SetActive(true);
                keyX = 0;
                while (keyX < 40)
                {
                    _key.transform.localPosition += new Vector3(0.001f, 0,0 );
                    keyX++;
                    yield return new WaitForSeconds(0.008f);
                }
                keyXRot = -90;
                while (keyXRot < 0)
                {
                    _key.transform.localRotation = Quaternion.Euler(keyXRot, 180, 0);
                    keyXRot++;
                    yield return new WaitForSeconds(0.01f);
                }

            y = 90;
            while (y >= 0)
            {
               transform.localRotation = Quaternion.Euler(0, y, 0);
                y--;
                yield return new WaitForSeconds(0.01f);
            }
            _turn = false;
        }
        else
        {
            ActivateInteraction(false);
            y = 0;
            while (y <= 90)
            {
                transform.localRotation = Quaternion.Euler(0, y, 0);
                y++;
                yield return new WaitForSeconds(0.01f);
            }

       
        keyXRot = 0;
        while (keyXRot > -90)
        {
            _key.transform.localRotation = Quaternion.Euler(keyXRot, 180, 0);
            keyXRot--;
            yield return new WaitForSeconds(0.01f);
        }
        keyX = 40;
        while (keyX > 0)
        {
            _key.transform.localPosition -= new Vector3(0.001f, 0, 0);
            keyX--;
            yield return new WaitForSeconds(0.008f);
        }
        _key.SetActive(false);
        }


    }
}
