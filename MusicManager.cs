using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Script pour que la musique ne s'arrête pas même si on change de scène
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
