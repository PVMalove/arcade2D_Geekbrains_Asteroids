using UnityEngine;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Enemy Data", fileName = "EnemyData", order = 51)]
    public class EnemyData : ScriptableObject
    {
        [SerializeField] private GameObject prefab;
    }
}