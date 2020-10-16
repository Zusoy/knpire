using UnityEngine;

namespace Knpire.Player
{
    /// <summary>
    /// Handle Tank Turret Orientation
    /// </summary>
    public class TankTurretBehaviour : MonoBehaviour
    {
        private void Update()
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit mouseHit;

            if (Physics.Raycast(mouseRay, out mouseHit))
            {
                Vector3 lookAt = new Vector3(mouseHit.point.x, 0, mouseHit.point.z);
                this.transform.LookAt(lookAt);
            }
        }
    }
}
