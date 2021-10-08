using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Models.Items
{
    public class HealthPotion : MonoBehaviour, IItem
    {
        public string Name { get; set; } = "Health potion";
        public string Description { get; set; } = "Restores your health";
    }
}
