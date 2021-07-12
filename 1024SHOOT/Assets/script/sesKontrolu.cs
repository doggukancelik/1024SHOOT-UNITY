using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sesKontrolu : MonoBehaviour
{
    public Slider sesAyari;
    private musicOynaticisi muzigim;
    public sahneKontrolu sahne;
    void Start()
    {
        sesAyari.value = playerPrefs.anaSesAl();
        muzigim = GameObject.FindObjectOfType<musicOynaticisi>();
        //muzigim.sesiAyarla(0.25f);
        playerPrefs.AnaSesAyari(0.3f);
        playerPrefs.anaSesAl();



    }

    // Update is called once per frame
    void Update()
    {
        muzigim.sesiAyarla(sesAyari.value);
        
        if (sesAyari.value > 0 )
        {
            AudioListener.pause = false;
        }
       
    }
    public void sesKaydet()
    {
        playerPrefs.AnaSesAyari(sesAyari.value);
        playerPrefs.anaSesAl();
    }
}
