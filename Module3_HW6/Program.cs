namespace Module3_HW6;

public class Program
{
    public static void Main(string[] args)
    {
        MessageBox messageBox = new MessageBox();
        messageBox.Open();
        if (messageBox.State == StateEnum.State.Ok)
        {
            Console.WriteLine("Operation was accepted");
        }
        else
        {
            Console.WriteLine("Operation was canceled");
        }
    }
}