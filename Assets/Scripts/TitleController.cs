using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ClickerGame {
    public class TitleController : MonoBehaviour {

        private void Start() {
            var startButton = this.GetComponent<Button>();

            startButton.onClick.AddListener(OnClickStartButton);
        }

        private void OnClickStartButton() {
            SceneManager.LoadScene("Main");
        }
    }
}

