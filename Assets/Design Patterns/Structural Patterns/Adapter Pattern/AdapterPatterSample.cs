using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Adapter
{
    public class AdapterPatterSample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            VibrateAdapter vibrator = new AndroidVibrateAdapter();
            vibrator.Vibrate();

            vibrator = new IosVibrateAdapter();
            vibrator.Vibrate();
        }
    }

    public interface VibrateAdapter
    {
        void Vibrate();
    }

    public class AndroidVibrateAdapter : VibrateAdapter
    {
        public void Vibrate()
        {
            Debug.Log("Android Vibrate");
        }
    }

    public class IosVibrateAdapter : VibrateAdapter
    {
        public void Vibrate()
        {
            Debug.Log("Ios Vibrate");
        }
    }
}
