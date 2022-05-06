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
                while (keyX < 20)
                {
                    _key.transform.localPosition += new Vector3(0.002f, 0,0 );
                    keyX++;
                    yield return new WaitForSeconds(0.000002f);
                }
                keyXRot = -90;
                while (keyXRot < 0)
                {
                    _key.transform.localRotation = Quaternion.Euler(keyXRot, 180, 0);
                    keyXRot+=2;
                    yield return new WaitForSeconds(0.0000025f);
                }

            y = 90;
            while (y >= 0)
            {
               transform.localRotation = Quaternion.Euler(0, y, 0);
                y-=2;
                yield return new WaitForSeconds(0.0000025f);
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
                y+=2;
                yield return new WaitForSeconds(0.0000025f);
            }

       
        keyXRot = 0;
        while (keyXRot > -90)
        {
            _key.transform.localRotation = Quaternion.Euler(keyXRot, 180, 0);
            keyXRot-=2;
            yield return new WaitForSeconds(0.0000025f);
        }
        keyX = 20;
        while (keyX > 0)
        {
            _key.transform.localPosition -= new Vector3(0.002f, 0, 0);
            keyX-=2;
            yield return new WaitForSeconds(0.00002f);
        }
        _key.SetActive(false);
        }


    }
}
