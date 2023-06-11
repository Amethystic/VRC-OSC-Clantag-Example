using SharpOSC;

/* this is just an example for the mod makers out there that is still making mods */

class Program
{
    public static UDPSender sender = new UDPSender("127.0.0.1", 9000);
    public static string text = "ClanTag Example";

    static void Main(string[] args)
    {
        /* You can take out this whole entire codeblock if u wanna make it straight into the point */
        Console.WriteLine(@"  ___  __      __    _  _  ____   __    ___   ___  ____  ____ /\
 / __)(  )    /__\  ( \( )(_  _) /__\  / __) / __)( ___)(  _ \)(
( (__  )(__  /(__)\  )  (   )(  /(__)\( (_-.( (_-. )__)  )   /\/
 \___)(____)(__)(__)(_)\_) (__)(__)(__)\___/ \___/(____)(_)\_)()");
        Task.Delay(1500).Wait();
        Console.WriteLine("Loading...");
        Task.Delay(5500).Wait();
        /* You can take out this whole entire codeblock if u wanna make it straight into the point */

        repeat();
        Console.ReadLine();
    }

    public static void sendMessage(string text)
    {
        Console.Clear();
        var message = new OscMessage("/chatbox/input", text, true);
        Console.WriteLine($"Sent OSC Message to chatbox: {text}");
        sender.Send(message);
    }

    public static async void repeat()
    {
        while (true)
        {
            sendMessage(text);
            await Task.Delay(5500);
        }
    }
}

/* this is just an example for the mod makers out there that is still making mods */