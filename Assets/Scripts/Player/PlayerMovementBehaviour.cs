using UnityEngine;

namespace Knpire.Player
{
    using Common;
    using Settings;

    /// <summary>
    /// Handle Player Movements
    /// </summary>
    public class PlayerMovementBehaviour : ConfigurableMonoBehaviour<PlayerSetting>
    {
        private void Update()
        {
            Vector2 input = new Vector2(Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));

            float movement = input.x * this.settings.Movement.MoveSpeed * Time.deltaTime;
            float rotation = input.y * this.settings.Movement.RotateSpeed * Time.deltaTime;

            this.transform.Translate(Vector3.forward * movement);
            this.transform.Rotate(Vector3.up * rotation);
        }
    }
}
