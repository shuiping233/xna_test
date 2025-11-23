using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XnaSanityCheck
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth  = 800,
                PreferredBackBufferHeight = 480
            };
            Content.RootDirectory = "Content";   // 空文件夹即可，无素材
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // 强制提前创建窗口句柄，避免“ShowMissingRequirementMessage”时再
            // get_Handle() 触发 ObjectDisposedException（本地验证时更稳）
            var _ = Window.Handle;
            base.Initialize();
        }

        protected override void LoadContent() { /* 无素材 */ }

        protected override void Update(GameTime gameTime)
        {
            // 按 ESC 直接退出
            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(
                Microsoft.Xna.Framework.Input.Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
}