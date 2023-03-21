using Code.Interfaces;
using UnityEngine;

namespace Code
{
    public class MoveTransform : IMove
    {
        private readonly Rigidbody2D _rigidbody;
        
        public float Speed { get; protected set; }

        protected MoveTransform(Rigidbody2D rigidbody, float speed)
        {
            _rigidbody = rigidbody;
            Speed = speed;
        }

        public void Move(float vertical, float deltaTime)
        {
            float speed = deltaTime * Speed;
           _rigidbody.velocity = _rigidbody.transform.up * (vertical * speed);
        }
    }
}