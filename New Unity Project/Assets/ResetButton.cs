using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Assets
{
 public   class ResetButton:MonoBehaviour
    {

        [SerializeField] public Button _resetButton;
        void Start()
        {
            _resetButton.onClick.AddListener(() => OnButtonClick());
        
        }

        public void OnButtonClick()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

           
        }
    }
}
