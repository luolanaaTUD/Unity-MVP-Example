using System;

namespace Common.Model
{
    public class BlacksmithModel
    {
        private int _lives;

        public int Lives => _lives;

        public event Action OnLivesAdded;

        public BlacksmithModel()
        {
            _lives = 10;
        }

        public void AddLives(int amount)
        {
            _lives += amount;
            OnLivesAdded?.Invoke();
        }
    }
}