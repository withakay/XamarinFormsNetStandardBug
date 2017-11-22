using System;
namespace XamarinFormsNetStandard.Services
{
    public class AblyTest
    {

        AblyMessenger _messenger;

        public AblyTest()
        {
            _messenger = new AblyMessenger();
            _messenger.SendMessage("testing 123");
        }
    }
}
