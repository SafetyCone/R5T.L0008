using System;


namespace MimeKit
{
    public static class InternetAddressExtensions
    {
        public static string GetAddress(this InternetAddress internetAddress)
        {
            if(internetAddress is MailboxAddress mailboxAddress)
            {
                return mailboxAddress.Address;
            }
            else
            {
                if(internetAddress is GroupAddress groupAddress)
                {
                    // TODO, handle group addresses!
                    throw new Exception("Group addresses are unhandled.");
                }
                else
                {
                    throw new Exception($"Unknown internet address type:\n{internetAddress.GetType().FullName}");
                }
            }
        }
    }
}
