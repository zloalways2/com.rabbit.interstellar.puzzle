using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _project.Scripts
{
    [CreateAssetMenu(fileName = "Levels", menuName = "Game/Levels", order = 0)]
    public sealed class mhjngbgfvdfcsevrtrh : ScriptableObject
    {
       [FormerlySerializedAs("levels")] [SerializeField] private List<eregtrhynthbgfdvfscwevrtb> rocketLevels = new List<eregtrhynthbgfdvfscwevrtb>();

        public IReadOnlyList<eregtrhynthbgfdvfscwevrtb> gjnhfbgdvfscdbttng => rocketLevels;
    }
}