using System;


namespace MimeKit
{
    public static class MimeMessageHelper
    {
        public const string NonExistentHtmlBody = null;
        public const string NonExistentTextBody = null;


        public static bool HasHtmlBody(MimeMessage message)
        {
            var output = message.HtmlBody != MimeMessageHelper.NonExistentHtmlBody;
            return output;
        }

        public static bool HasTextBody(MimeMessage message)
        {
            var output = message.TextBody != MimeMessageHelper.NonExistentTextBody;
            return output;
        }
    }
}
