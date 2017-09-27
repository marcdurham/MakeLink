namespace MakeLink
{
    public class RequestParser
    {
        public static Request Parse(string[] args)
        {
            var request = new Request
            {
                Help = args.Length == 0
            };

            foreach (string arg in args)
            {
                if (arg.StartsWith(Tags.Target))
                    request.Target = arg.Substring(Tags.Target.Length);
                else if (arg.StartsWith(Tags.Output))
                    request.Output = arg.Substring(Tags.Output.Length);
                else if (arg.StartsWith(Tags.Icon))
                    request.Icon = arg.Substring(Tags.Icon.Length);
                else if (arg.StartsWith(Tags.Arguments))
                    request.Arguments = arg.Substring(Tags.Arguments.Length);
                else if (arg.StartsWith(Tags.WorkingDirectory))
                    request.WorkingDirectory = arg.Substring(Tags.WorkingDirectory.Length);
                else if (arg.StartsWith(Tags.Description))
                    request.Description = arg.Substring(Tags.Description.Length);
            }

            return request;
        }
    }
}
