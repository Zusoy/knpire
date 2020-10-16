using UnityEngine;

namespace Knpire.Game
{
    using Enemy;
    using UI;

    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;

        private EnemySpawner EnemySpawner;

        [SerializeField]
        private WaveCounter WaveCounterUI;

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
            this.EnemySpawner = this.GetComponent<EnemySpawner>();
        }

        public void OnPlayerDeath()
        {
            Debug.Log("Player Death!!");
            this.PlayerDead = true;
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
