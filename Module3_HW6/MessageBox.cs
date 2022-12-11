using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Module3_HW6;
public class MessageBox
{
    public MessageBox()
    {
        TryCloseWindow = WindowCloseHandler;
    }

    public delegate void WindowHandler(StateEnum.State state);
    public event WindowHandler TryCloseWindow;
    public StateEnum.State State { get; set; }
    public async void Open()
    {
        Console.WriteLine("Window was opened");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Window was closed by a user");

        Random random = new Random();
        int randomNum = random.Next(0, 100);

        Console.WriteLine("Randomly generated number " +
            "(if <=50 State=OK, else State=Cancel) - " + randomNum);

        if (randomNum <= 50)
        {
            TryCloseWindow.Invoke(StateEnum.State.Ok);
        }
        else
        {
            TryCloseWindow.Invoke(StateEnum.State.Cancel);
        }
    }

    public void WindowCloseHandler(StateEnum.State state)
    {
        State = state;
    }
}