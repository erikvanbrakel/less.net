namespace LessCss.Preprocessor
{
    using System.Text;

    public interface IDescriptorBuilder
    {
        string BuildDescriptor(char[] input);
    }

    public class DescriptorBuilder : IDescriptorBuilder
    {
        public string BuildDescriptor(char[] input)
        {
            var builder = new StringBuilder();
            builder.Append(input);
            return builder.ToString().Trim();
        }
    }
}