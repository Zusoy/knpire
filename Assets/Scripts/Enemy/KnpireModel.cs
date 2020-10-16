using UnityEngine;

namespace Knpire.Enemy
{
    [CreateAssetMenu(fileName = "KNPire", menuName = "KNPIRE")]
    public class KnpireModel : ScriptableObject
    {
        public Texture Face;
        public AudioClip Quote;
    }
}
