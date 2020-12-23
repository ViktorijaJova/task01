using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Assets
{
   public class FirstButton:MonoBehaviour
    {
        [SerializeField] private Button _firstButton;
       [SerializeField] public GameObject _firstcube;


        void Start()
        {
            _firstButton.onClick.AddListener(() => OnButtonClick());
        }


        public void OnButtonClick()
        {
          //  GameObject s = GameObject.Find("Cubeone");
             //   s.GetComponent<Renderer>().sharedMaterial.color = Color.yellow;
           _firstcube.GetComponent<Renderer>().material.color = Color.yellow;
            
        }

   
    }
}
