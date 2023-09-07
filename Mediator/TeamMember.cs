using System.Runtime.InteropServices;

namespace Mediator;

public abstract class TeamMember
{
    private IChatRoom? _chatroom;
    public string Name { get; set; }

    protected TeamMember(string name)
    {
        Name = name;
    }

    internal void SetChatroom(IChatRoom chatRoom)
    {
        _chatroom = chatRoom;
    }

    public void Send(string message)
    {
        _chatroom?.Send(Name, message);
    }

    public void Send(string to, string message)
    {
        _chatroom?.Send(Name, to, message);
    }
    
    public void SendTo<T>(string message) where T: TeamMember
    {
        _chatroom?. SendTo<T>(Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"Message {from} to {Name}: {message}");
    }
}