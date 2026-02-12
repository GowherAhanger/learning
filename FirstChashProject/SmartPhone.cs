namespace FirstChashProject;

public class SmartPhone : IPhone,IMusicPlayer,ICamera
{
    public void takePicture()
    {
        Console.WriteLine("Smart Phone can take pictures");
    }

    public void Call()
    {
        Console.WriteLine("Smart Phone calling 9149123456");
    }

    public void playMusic()
    {
        Console.WriteLine("Smart Phone playing music");
    }
}