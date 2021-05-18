using System;
using System.Collections.Generic;
using System.Linq;


namespace MimeKit
{
    public static class InternetAddressListExtensions
    {
        public static List<string> GetAddresses(this InternetAddressList internetAddresses)
        {
            var output = internetAddresses
                .Select(x => x.GetAddress())
                .ToList();

            return output;
        }

        /// <summary>
        /// Throws if there is more than one address.
        /// </summary>
        public static string GetSingleAddress(this InternetAddressList internetAddresses)
        {
            var output = internetAddresses
                .Single()
                .GetAddress();

            return output;
        }
    }
}
