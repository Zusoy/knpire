using UnityEngine;

namespace Knpire.Enemy.Settings
{
    using Sections;

    [CreateAssetMenu(fileName = "Enemy Settings", menuName = "Settings/Enemy")]
    public class EnemySetting : ScriptableObject
    {
        public EnemySpawnSettingSection Spawn;
        public EnemyAISettingSection Enemy;
    }
}
