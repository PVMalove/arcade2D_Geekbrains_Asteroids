using Code.Interfaces;
using UnityEngine;

namespace Code
{
    internal sealed class RotationTransform : IRotation
    {
        private readonly Rigidbody2D _rigidbody;
        
        public float RotationSpeed { get; }

        public RotationTransform(Rigidbody2D rigidbody, float rotationSpeed)
        {
            _rigidbody = rigidbody;
            RotationSpeed = rotationSpeed;
        }

        public void Rotate(float horizontal, float deltaTime)
        {
            float speed = deltaTime * RotationSpeed;
            _rigidbody.angularVelocity = _rigidbody.transform.forward.magnitude * (horizontal * speed);
        }
    }
}