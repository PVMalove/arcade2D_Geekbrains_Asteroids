﻿using Code.Interfaces;

namespace Code
{
    public class PlayerController : IUpdatable
    {
        private readonly PlayerModel _model;
        private readonly IPlayerView _view;

        public PlayerController(PlayerModel model, IPlayerView view)
        {
            _model = model;
            _view = view;
            _view.SetModel(_model);
        }

        public void OnUpdate(float deltaTime)
        {
            _view.OnUpdate(deltaTime);
        }
    }
}