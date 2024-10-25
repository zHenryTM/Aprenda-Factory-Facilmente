#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


public interface IMessage
{
    public abstract void Send(string message);
}


public class SMSMessage : IMessage
{
    // Método abstrato da interface
    public void Send(string message)
    {
        message = (message == null) ? "" : message;        
        Console.WriteLine("Mensagem enviada por SMS: " + message);
    }
}


public class EmailMessage : IMessage
{
    // Método abstrato da interface
    public void Send(string message)
    {
        message = (message == null) ? "" : message; 
        Console.WriteLine("Mensagem enviada por Email: " + message);
    }
}


public class PushNotificationMessage : IMessage
{
    // Método abstrato da interface
    public void Send(string message)
    {
        message = (message == null) ? "" : message; 
        Console.WriteLine("Mensagem enviada por Notification: " + message);
    }
}


public class MessageFactory
{
    public IMessage? GetMessage(string messageType)
    {    
        if (messageType.Equals("SMS", StringComparison.CurrentCultureIgnoreCase))
        {
            return new SMSMessage();
        }
        else if (messageType.Equals("Email", StringComparison.CurrentCultureIgnoreCase))
        {
            return new EmailMessage();
        }
        else if (messageType.Equals("PushNotification", StringComparison.CurrentCultureIgnoreCase))
        {
            return new PushNotificationMessage();
        }
        else
        {
            return null;
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        MessageFactory messageFactory = new MessageFactory();  // Criando uma instância da classe fábrica

        IMessage? message = messageFactory.GetMessage("SMS");  // Irá retornar uma instância de SMSMessage

        message.Send("Subo nesse palco. Minha alma cheira a talco...");  // Mandará uma mensagem usando SMSMessage
    }
}
