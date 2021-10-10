using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Silah : MonoBehaviour
{
    public float gule;

    public float magazin;

    public float toplam_gule;

    public float novbeti_ates;

    public float ates_zamani;

    public float mesafe = 350;

    public float gule_hesablama;

    public float magazin_deyisme_vaxti;

    public float maxvaxt;

    public bool ates;

    public bool reload;

    public Text guleyazi;

   
    
    void Start()
    {
        magazin_deyisme_vaxti = maxvaxt;
    }

    
    void Update()
    {
        if(Input.GetMouseButton(0) && gule > 0 && Time.time > novbeti_ates && !reload)
        {
            guleyazi.text = ""+ gule + " / " + toplam_gule;
            ates = true;
            gule--;
            novbeti_ates = Time.time + ates_zamani;
        }

        if (Input.GetKeyDown(KeyCode.R) && gule != 30 && !reload)
        {
            reload = true;
        }

        if (reload)
        {
          reload = false;
            magazin_deyisme_vaxti -= Time.deltaTime;
            if(gule_hesablama > toplam_gule)
            {
                toplam_gule = 0;
                gule += toplam_gule;
            }
            if (gule < toplam_gule)
            {
                gule_hesablama = magazin - gule;
                gule += gule_hesablama;
                toplam_gule -= gule_hesablama;
            }
        }




    }
}
