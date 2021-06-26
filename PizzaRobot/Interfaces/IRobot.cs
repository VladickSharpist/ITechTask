using System.Text;

namespace PizzaRobot.Interfaces
{
    public interface IRobot
    {
        Point Position { get; set; }
        StringBuilder Route { get; }
        void Move(Point moveToPoint);
        public void DropPizza();
    }
}