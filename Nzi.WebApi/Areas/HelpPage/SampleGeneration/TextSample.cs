using System;

namespace Nzi.WebApi.Areas.HelpPage
{
    /// <summary>
    /// This represents a preformatted text sample on the help page. There's a display template named TextSample associated with this class.
    /// </summary>
    public class TextSample
    {
        public TextSample( string text, string textextend, Type type )
        {
            if( text == null )
            {
                throw new ArgumentNullException("text");
            }
            Text = text;
            TextExtend = textextend;
            Type = type;
        }

        public TextSample( string text ) : this(text, string.Empty, null)
        {
        }

        public Type Type { get; private set; }

        public string TextExtend { get; private set; }

        public string Text { get; private set; }

        public override bool Equals(object obj)
        {
            TextSample other = obj as TextSample;
            return other != null && Text == other.Text;
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }

        public override string ToString()
        {
            return Text;
        }
    }
}