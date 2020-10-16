using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Knpire.Enemy
{
    using Game;
    using Common;
    using Settings;

    public class EnemySpawner : ConfigurableMonoBehaviour<EnemySetting>
    {
        [SerializeField]
        private List<Transform> spawnPoints = new List<Transform>();

        private int enemyCount;

        private bool isStartingWave = false;

        private void Start()
        {
            this.enemyCount = this.settings.Spawn.StartEnemyCount;
            this.InitNewWave();
        }

        public bool IsStartingNewWave()
        {
            return this.isStartingWave;
        }

        public void InitNewWave()
        {
            this.isStartingWave = true;
            this.StartCoroutine("StartWave");
        }

        private IEnumerator StartWave()
        {
            yield return new WaitForSeconds(this.settings.Spawn.WaveCooldown);
            this.PrepareWave();
        }

        private void PrepareWave()
        {
            Debug.Log("New Wave...");
            GameManager.Instance.NextWave();

            if (GameManager.Instance.GetCurrentWave() > 1)
            {
                this.enemyCount += this.settings.Spawn.NextWaveEnemyAddition;
            }

            this.StartCoroutine("SpawnEnemiesWaveWithDelay");
        }

        private IEnumerator SpawnEnemiesWaveWithDelay()
        {
            for (int i = 1; i <= this.enemyCount; i++)
            {
                yield return new WaitForSeconds(this.settings.Spawn.EnemySpawnDelay);
                this.SpawnEnemyAtRandomPoint();
            }

            this.isStartingWave = false;
        }

        private GameObject SpawnEnemyAtRandomPoint()
        {
            int index = Random.Range(1, this.spawnPoints.Count);
            int knpireIndex = Random.Range(0, this.settings.Spawn.KnpireModels.Count);

            Transform spawn = this.spawnPoints[index];
            KnpireModel knpire = this.settings.Spawn.KnpireModels[knpireIndex];

            Vector3 spawnPos = new Vector3(spawn.position.x, 5f, spawn.position.z);
            GameObject enemy = Instantiate(this.settings.Spawn.Enemy, spawnPos, Quaternion.identity);
            Renderer rendering = enemy.GetComponent<Renderer>();

            rendering.material.mainTexture = knpire.Face;

            GameManager.Instance.GetSoundManager().PlaySound(knpire.Quote);

            return enemy;
        }
    }
}
