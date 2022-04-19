using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectsContainer : MonoBehaviour
{
    public static ObjectsContainer Instance;

    [SerializeField] private List<BaseObject> _baseObjects = new List<BaseObject>();
    [SerializeField] private List<InteractObject> _interactObjects = new List<InteractObject>();
    private ObjectsContainer(){}

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public BaseObject TryGetBaseObject(string name)
    {
        BaseObject tempObject = _baseObjects.FirstOrDefault(p => p.GetBaseObjectName() == name);
        if (tempObject != null)
            return tempObject;
        else
            return null;
    }
    public InteractObject TryGetInteractObject(string name)
    {
        InteractObject tempObject = _interactObjects.FirstOrDefault(p => p.GetInteractObjectName() == name);
        if (tempObject != null)
            return tempObject;
        else
            return null;
    }

}
