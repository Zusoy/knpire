using UnityEngine;

namespace Knpire.Player
{
    /// <summary>
    /// Handle Player Movements
    /// </summary>
    public class PlayerMovementBehaviour : MonoBehaviour
    {
        [SerializeField]
        private float moveSpeed;

        [SerializeField]
        private float rotateSpeed;

        private void Update()
        {
            Vector2 input = new Vector2(Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));

            float movement = input.x * this.moveSpeed * Time.deltaTime;
            float rotation = input.y * this.rotateSpeed * Time.deltaTime;

            this.transform.Translate(Vector3.forward * movement);
            this.transform.Rotate(Vector3.up * rotation);
        }
    }
}
