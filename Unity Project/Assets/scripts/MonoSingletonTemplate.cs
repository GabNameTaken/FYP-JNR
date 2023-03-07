using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingletonTemplate<T> : MonoBehaviour
{
    #region Fields

    protected static T m_instance = default; 
    bool thisInstance = false;

    #endregion

    #region Properties

    public static T instance
    {
        get { return m_instance; }
    }

    #endregion

    /**
         * @fn InitializeSingleton
         * @brief This function must be called in the inherited class to initialize the Singleton.
         * @param T _newInstance The instance. Usually "this".
         */
    protected void InitializeSingleton(T _newInstance, bool DontDestroy = true)
    {
        if (m_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            thisInstance = true;
            m_instance = _newInstance;
            if (DontDestroy)
                DontDestroyOnLoad(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (thisInstance)
        {
            m_instance = default;
        }
    }
}
