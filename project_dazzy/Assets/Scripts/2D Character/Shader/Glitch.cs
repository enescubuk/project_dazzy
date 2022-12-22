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
    
    void Start()
    {
        Glitchx.scanLineJitter = 0.5f;
        Glitchx.verticalJump = 0.11f;
        Glitchx.colorDrift = 0.2f;
        GlitchEffect.intensity = 0.1f;
        StartCoroutine(GlitchEffectControl());
    }
    private void Update()
    {
        if (EffectControl)
        {
            Glitchx.colorDrift -= 0.015f * Time.deltaTime;
            Glitchx.verticalJump -= 0.015f * Time.deltaTime;
            Glitchx.scanLineJitter -= 0.015f * Time.deltaTime;
            GlitchEffect.intensity -= 0.015f * Time.deltaTime;
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

    IEnumerator GlitchEffectControl()
    {
        yield return new WaitForSeconds(0.2f);
        EffectControl = true;
    }
}
