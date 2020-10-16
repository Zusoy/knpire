using UnityEngine;
using System.Collections.Generic;

namespace Knpire.Enemy.Settings.Sections
{
    [System.Serializable]
    public class EnemySpawnSettingSection
    {
        [Header("The Enemy Object")]
        public GameObject Enemy;

        [Header("Start number of enemies in World")]
        public int StartEnemyCount;

        [Header("Number of enemies to add for each wave")]
        public int NextWaveEnemyAddition;

        [Header("Wave Cooldown before starting")]
        public float WaveCooldown;

        [Header("Time to wait beetween each spawn of enemy")]
        public float EnemySpawnDelay;

        [Header("KNPire Models")]
        public List<KnpireModel> KnpireModels = new List<KnpireModel>();
    }
}
