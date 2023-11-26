using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLib.Shapes;
using System.Collections.Generic;
using TTG.Helpers;

namespace TTG.Classes
{
    public class Menu
    {
        public Text title { get; set; }
        public List<Option> options { get; private set; } = new List<Option>();
        public float Energy { get; private set; }
        public Option selected { get; private set; }

        public Menu(Text pTitle)
        {
            title = pTitle;
        }
        public void AddEnergy(float energy = 1)
        {
            Energy += energy;
        }
        public void RemoveEnergy(float energy = 1)
        {
            Energy -= energy;
        }
        public void AddOption(Option option)
        {


            options.Add(option);
        }
        public void RemoveOption(Option option)
        {
            options.Remove(option);
        }
        public void Draw(SpriteBatch sb)
        {
            sb.Draw(title);

            foreach (Option option in options)
            {
                option.Draw(sb);
            }
        }
        public void ChangeTitle(string text)
        {
            title = new Text(text, title.Font, title.position, title._colour);
        }

        public void updateOptions(Vector2 target)
        { 
            foreach (Option option in options)
            {
                if (option.isInside(target))
                {
                    option.text.changeColour(Color.Blue);
                    selected = option;

                }
                else
                {
                    option.text.changeColour(Color.White);
                    selected = null;
                }
            }
        }




    }
}
