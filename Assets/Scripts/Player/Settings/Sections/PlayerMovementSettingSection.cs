using UnityEngine;

namespace Knpire.Player.Settings.Sections
{
    [System.Serializable]
    public class PlayerMovementSettingSection
    {
        [Header("The Player movement speed")]
        public float MoveSpeed;

        [Header("The Player rotation speed")]
        public float RotateSpeed;
    }
}
