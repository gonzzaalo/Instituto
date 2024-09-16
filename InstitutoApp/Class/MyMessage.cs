using CommunityToolkit.Mvvm.Messaging.Messages;
using InstitutoServices.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoApp.Class
{
    public class MyMessage : ValueChangedMessage<string>
    {
        public Carrera Carrera { get; set; }

        public MyMessage(string value):base(value)
        {
                
        }
    }
}
