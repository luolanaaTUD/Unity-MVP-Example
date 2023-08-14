using System;
using Common.Model;
using Common.View;

namespace Common.Presenter
{
    public class BlacksmithPresenter : IBlacksmithPresenter
    {
        readonly IBlacksmithView view;
        readonly BlacksmithModel model;

        public BlacksmithPresenter(IBlacksmithView view)
        {
            model = new BlacksmithModel();
            this.view = view;

            model.OnLivesAdded += Addlives;
        }

        public void Addlives()
        {
            model.AddLives(10);
            view.SetLives(model.Lives);
        }

        public void Dispose()
        {
            model.OnLivesAdded -= Addlives;
        }

        public void Greet()
        {
            view.PlayAnimation("greet");
        }

        public void Jump()
        {
            view.DoJump();
        }
    }
}