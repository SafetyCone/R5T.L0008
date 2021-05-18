using System;


namespace MimeKit
{
    public static class MimeMessageExtensions
    {
        public static bool HasHtmlBody(this MimeMessage message)
        {
            var output = MimeMessageHelper.HasHtmlBody(message);
            return output;
        }

        public static bool HasTextBody(this MimeMessage message)
        {
            var output = MimeMessageHelper.HasTextBody(message);
            return output;
        }
    }
}
