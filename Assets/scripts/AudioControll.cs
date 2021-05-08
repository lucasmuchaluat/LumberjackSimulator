using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioControll : MonoBehaviour
{
   // Referência aos Sliders e AudioMixer para conseguir definir pelo Inspector.
   public Slider masterSlider;
   public Slider sfxSlider;
   public Slider musicSlider;

   public AudioMixer master;

   float outMaster;
   float outSFX;
   float outAudio;
   
  // Inicializo os sliders nos limites dem db do mixer e já com os valores que estão salvos no mixer
   void Start()
   {
       master.GetFloat("Master", out outMaster);
       masterSlider.minValue = 0.0f;
       masterSlider.maxValue = 100.0f;
       masterSlider.value = outMaster;
       //Registro o evento de mudança de slider.
       masterSlider.onValueChanged.AddListener(delegate { SliderChanged(masterSlider); });
       
       master.GetFloat("SFX", out outSFX);
       sfxSlider.minValue = 0.0f;
       sfxSlider.maxValue = 100.0f;
       sfxSlider.value = outSFX;
       //Registro o evento de mudança de slider.
       sfxSlider.onValueChanged.AddListener(delegate { SliderChanged(sfxSlider); });


       master.GetFloat("Music", out outAudio);
       musicSlider.minValue = 0.0f;
       musicSlider.maxValue = 100.0f;
       musicSlider.value = outAudio;
       //Registro o evento de mudança de slider.
       musicSlider.onValueChanged.AddListener(delegate { SliderChanged(musicSlider); });
   }

   // Método responsável por alterar os volumes no AudioMixer de acordo com slider que foi modificado.
    public void SliderChanged(Slider slider)
   {
       if(slider == masterSlider)
       {
           master.SetFloat("Master", slider.value);
       }
       else if(slider == sfxSlider)
       {
           master.SetFloat("SFX", slider.value);
       }
       else if(slider == musicSlider)
       {
           master.SetFloat("Music", slider.value);
       }
   }
}