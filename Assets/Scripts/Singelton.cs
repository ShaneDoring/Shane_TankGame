using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singelton<T> : MonoBehaviour where T : Singelton<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            return instance;
        }
       // set
       // {
       //     instance = value;
       // }
    }

    public bool IsInitialized
    {
        get
        {
            return instance != null;
        }
    }

    protected virtual void Awake()
    {
        if (IsInitialized)
        {
            Debug.LogError("[Singleton] Tried To Create A Second Instance Of A Singleton Class!");
            GameObject.Destroy(this.gameObject);
        }
        else
        {
            instance = (T) this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    protected virtual void OnDestroy()
    {
        instance = null;
    }
}
