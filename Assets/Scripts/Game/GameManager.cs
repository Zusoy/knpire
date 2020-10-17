using UnityEngine;
using UnityEngine.SceneManagement;

namespace Knpire.Game
{
    using Enemy;
    using UI;

    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;

        private EnemySpawner EnemySpawner;

        private SoundManager SoundManager;

        [SerializeField]
        private WaveCounter WaveCounterUI;

        [SerializeField]
        private GameOverPanel GameOverPanel;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.Find("GameManager").GetComponent<GameManager>();
                }

                return _instance;
            }
        }

        private int CurrentWave = 0;
        private bool PlayerDead = false;


        private void Start()
        {
            this.GameOverPanel.gameObject.SetActive(false);

            this.EnemySpawner = this.GetComponent<EnemySpawner>();
            this.SoundManager = this.GetComponent<SoundManager>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        public void OnPlayerDeath()
        {
            this.PlayerDead = true;
            this.GameOverPanel.gameObject.SetActive(true);
        }

        public void NextWave()
        {
            this.CurrentWave += 1;
            this.WaveCounterUI.DisplayWave(this.CurrentWave);
        }

        public void ResetWave()
        {
            this.CurrentWave = 0;
            this.WaveCounterUI.DisplayWave(this.CurrentWave);
        }

        public int GetCurrentWave()
        {
            return this.CurrentWave;
        }

        public bool IsPlayerDead()
        {
            return this.PlayerDead;
        }

        public SoundManager GetSoundManager()
        {
            return this.SoundManager;
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(0);
        }

        public void OnEnemyKilled()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            if (enemies.Length - 1 <= 0 && !this.EnemySpawner.IsStartingNewWave())
            {
                Debug.Log("init new wave");
                this.EnemySpawner.InitNewWave();
            }
        }
    }
}
