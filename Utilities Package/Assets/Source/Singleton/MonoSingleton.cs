using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : Component
{
    public static T Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError($"{Instance.GetType()} Already Exist");
            DestroyImmediate(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        Instance = this as T;
    }
}
