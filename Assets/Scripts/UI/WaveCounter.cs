using UnityEngine;
using UnityEngine.UI;

namespace Knpire.UI
{
    public class WaveCounter : MonoBehaviour
    {
        public void DisplayWave(int wave)
        {
            this.GetComponent<Text>().text = "Wave : " + wave.ToString();
        }
    }
}
