using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonScriptableOnject<T> : ScriptableObject where T : ScriptableObject
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            T[] results = Resources.FindObjectsOfTypeAll<T>();
            if (results.Length == 0)
            {
                Debug.LogError("No instance of " + typeof(T).Name + " found in the scene.");
                return null;
            }
            else if (results.Length > 1)
            {
                Debug.LogError("More than one instance of " + typeof(T).Name + " found in the scene.");
                return null;
            }
            else
            {
                _instance = results[0];
                return _instance;
            }
        }
    }
}
