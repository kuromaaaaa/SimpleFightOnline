using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
    protected bool DDOL = false;
    private static T instance;
    public static T Instance
    {
        get { return instance; }
        set { instance = value; }
    }
    protected void Awake()
    {
        if (instance == null)
        {
            instance = (T)FindObjectOfType(typeof(T));
        }
        else
        {
            Destroy(this);
        }
    }

    private void OnDestroy()
    {
        if (ReferenceEquals(this, instance))
            instance = null;
    }
    private void Start()
    {
        if (DDOL)
        {
            DontDestroyOnLoad(instance);
        }
    }
}