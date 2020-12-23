using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Assets
{
    public class SecondButton : MonoBehaviour
    {
        [SerializeField] private Button _secondButton;
        [SerializeField] private GameObject _secondcube;


        void Start()
        {
            _secondButton.onClick.AddListener(() => OnButtonClick());
        }


        public void OnButtonClick()
        {
            // _secondcube.GetComponent<Renderer>().sharedMaterial.color = Color.red;
            //  GameObject a = GameObject.Find("Cubetwo");
            _secondcube.transform.position = new Vector3(0,0,-1f);
        }
    }
}
