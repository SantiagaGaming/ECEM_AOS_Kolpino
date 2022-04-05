using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyObject : BaseObject
{
    [SerializeField] private GameObject _key;

    public override void StartAction()
    {

        StartCoroutine(OpenCloseLocker(true));
    }
    public override void RevertAction()
    {
        StartCoroutine(OpenCloseLocker(false));
    }
    private IEnumerator OpenCloseLocker(bool value)
    {
        canAction = false;
        _key.SetActive(true);
        if (value)
        {
            _key.SetActive(true);
            int keyX = 0;
            while (keyX < 40)
            {
                _key.transform.localPosition -= new Vector3(0, 0, 0.00001f);
                keyX++;
                yield return new WaitForSeconds(0.005f);
            }
            int keyXRot = -90;
            while (keyXRot > -180)
            {
                _key.transform.localRotation = Quaternion.Euler(keyXRot, 270, 0);
                keyXRot--;
                yield return new WaitForSeconds(0.01f);
            }
      

        }
        else
        {

            int keyXRot = -180;
            while (keyXRot < -90)
            {
                _key.transform.localRotation = Quaternion.Euler(keyXRot, 270, 0);
                keyXRot++;
                yield return new WaitForSeconds(0.01f);
            }
            int keyX = 40;
            while (keyX > 0)
            {
                _key.transform.localPosition += new Vector3(0, 0, 0.00001f);
                keyX--;
                yield return new WaitForSeconds(0.01f);
            }
            _key.SetActive(false);

        }

        canAction = true;
    }
}


