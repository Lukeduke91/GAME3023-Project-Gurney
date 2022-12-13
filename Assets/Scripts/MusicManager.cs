using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private MusicManager() { }

    private static MusicManager instance = null;
    public static MusicManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<MusicManager>();
            }
            return instance;
        }
        private set { instance = value; }
    }

    [Tooltip("One track for cross fading. The order is arbitrary")]
    [SerializeField]
    AudioSource MusicSource1;

    [Tooltip("Another track for cross fading. The order is arbitrary")]
    [SerializeField]
    AudioSource MusicSource2;

    // Start is called before the first frame update
    void Start()
    {
        MusicManager original = Instance;

        MusicManager[] managers = GameObject.FindObjectsOfType<MusicManager>();
        foreach(MusicManager manager in managers)
        {
            if(manager != original)
            {
                Destroy(manager.gameObject);
            }
        }
    }
}
