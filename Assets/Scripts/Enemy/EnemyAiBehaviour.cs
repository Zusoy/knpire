using UnityEngine;

namespace Knpire.Enemy
{
    using Game;
    using Common;
    using Settings;

    public class EnemyAiBehaviour : ConfigurableMonoBehaviour<EnemySetting>
    {
        private Transform Player = null;

        private void Start()
        {
            if (GameManager.Instance.IsPlayerDead())
                return;

            this.Player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void Update()
        {
            if (GameManager.Instance.IsPlayerDead())
                return;

            this.LookAtPlayer();
            this.ChasePlayer();
        }

        private void ChasePlayer()
        {
            this.transform.Translate(Vector3.forward * this.settings.Enemy.MoveSpeed * Time.deltaTime);
        }

        private void LookAtPlayer()
        {
            Vector3 lookAtPos = new Vector3(
                this.Player.position.x,
                0f,
                this.Player.position.z
            );

            this.transform.LookAt(lookAtPos);
        }
    }
}
