using UnityEngine;
using UnityEngine.UI;

namespace Knpire.UI
{
    using Game;

    public class GameOverPanel : MonoBehaviour
    {
        [SerializeField]
        private Text waveText;

        private void OnEnable()
        {
            this.waveText.text = "You survived to the wave " + GameManager.Instance.GetCurrentWave();
        }
    }
}
