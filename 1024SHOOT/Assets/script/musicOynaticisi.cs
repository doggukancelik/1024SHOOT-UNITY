using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicOynaticisi : MonoBehaviour
{
    static musicOynaticisi muzik;

    private void Awake()
    {
       
        if (muzik != null)
        {
            Destroy(gameObject);
        }
        else
        {
            muzik = this;
            GameObject.DontDestroyOnLoad(gameObject);

        }
    }

    public void sesiAyarla(float sesDegeri)
    {
       
        GetComponent<AudioSource>().volume = sesDegeri;
        playerPrefs.AnaSesAyari(sesDegeri);
        GetComponent<AudioSource>().volume = playerPrefs.anaSesAl();

    }
    void Start()
    {
        GetComponent<AudioSource>().volume = playerPrefs.anaSesAl();

    }

  
}
