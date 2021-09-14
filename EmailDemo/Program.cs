using System;
using System.Net.Mail;
using FluentEmail.Core;
using FluentEmail.Smtp;

namespace EmailDemo {
    class Program {
        static void Main(string[] args) {
            //testing setup
            var sender = new SmtpSender(() => new SmtpClient("localhost") { //our host we send it in our machine(it can be gmail or whatever server you want to send)
                EnableSsl = false, //by default you want ssl ON, but for test we can do it false
                DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory, //this way is quick test(we put it in a file
                PickupDirectoryLocation = @"C:\Demos" //we specify where we send the email (as a file in this path)
            });

            Email.DefaultSender = sender;
        }
    }
}
