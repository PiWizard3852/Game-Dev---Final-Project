using UnityEngine;
using Random = System.Random;

namespace Vehicles
{
    public class Log : MonoBehaviour
    {
        private readonly Random _random = new Random();
    
        private float _speed;
    
        public void Start()
        {
            _speed = .02f * _random.Next(1, 2);
        }

        public void Update()
        {
            var carTransform = transform;
            var carPosition = carTransform.position;
            carPosition += carTransform.right * _speed;
            carTransform.position = carPosition;
        }
    }
}
