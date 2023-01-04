using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kino;
using UnityEngine.PlayerLoop;

public class Glitch : MonoBehaviour
{
    public DigitalGlitch GlitchEffect;
    public AnalogGlitch Glitchx;
    private bool EffectControl;
    

    public GameObject Player;
    public GameObject Player2D;
    public GameObject Ground;
    public GameObject Camera2D;
    public GameObject MainCamera;

    public GameObject BlackCube;
    
    private void Update()
    {
        if (EffectControl)
        {
            
            Glitchx.colorDrift -= 0.035f * Time.deltaTime;
            Glitchx.verticalJump -= 0.025f * Time.deltaTime;
            Glitchx.scanLineJitter -= 0.035f * Time.deltaTime;
            GlitchEffect.intensity -= 0.035f * Time.deltaTime;
        }

        if (Glitchx.colorDrift <= 0)
        {
            Glitchx.colorDrift = 0;
        }
        if (Glitchx.verticalJump <= 0)
        {
            Glitchx.verticalJump = 0;
        }if (Glitchx.scanLineJitter <= 0)
        {
            Glitchx.scanLineJitter = 0;
        }if (GlitchEffect.intensity <= 0)
        {
            GlitchEffect.intensity = 0;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           OpenWindows();
        }

        if (other.gameObject.tag == "Player2D")
        {
            Debug.Log("çıktı");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player2D"))
        {
            CloseWindows();
        }
    }

    IEnumerator GlitchEffectControl()
    {
        yield return new WaitForSeconds(0.2f);
        EffectControl = true;
    }

    public void OpenWindows()
    {
        MainCamera.SetActive(false);
        Camera2D.SetActive(true);
        Ground.SetActive(true);
        Player2D.SetActive(true);
        Player.SetActive(false);
        Glitchx.scanLineJitter = 0.5f;
        Glitchx.verticalJump = 0.11f;
        Glitchx.colorDrift = 0.2f;
        GlitchEffect.intensity = 0.25f;
        StartCoroutine(GlitchEffectControl());
        Player.transform.position = new Vector3(-130,48,16);
        BlackCube.SetActive(false);
    }

    public void CloseWindows()
    {
        MainCamera.SetActive(true);
        Camera2D.SetActive(false);
        Ground.SetActive(false);
        Player2D.SetActive(false);
        Player.SetActive(true);
        BlackCube.SetActive(true);
    }
    
}
