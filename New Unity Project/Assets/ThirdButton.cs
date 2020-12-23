using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Assets
{
     public  class ThirdButton:MonoBehaviour
    {
        [SerializeField] private Button _thirdButton;
        [SerializeField] public GameObject _thirdcube;


        void Start()
        {
            _thirdButton.onClick.AddListener(() => OnButtonClick());
        }


        public void OnButtonClick()
        {
          //  GameObject t = GameObject.Find("Cubethree");
            _thirdcube.GetComponent<Renderer>().material.color = Color.blue;
            _thirdcube.transform.localScale = new Vector3(2F, 2F, 2F);


        }
    }
}
