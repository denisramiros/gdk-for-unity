using System;
using System.Collections.Generic;
using System.Linq;

namespace Improbable.Gdk.CodeGeneration.CodeWriter
{
    /// <summary>
    /// A grouping of un-trimmed text to be on consecutive lines.
    /// </summary>
    public class TextList : ICodeBlock
    {
        private readonly string snippetListSeparator;

        private readonly List<Text> textBlocks = new List<Text>();
        public int Count => textBlocks.Count;

        internal TextList(IEnumerable<string> snippets)
        {
            snippetListSeparator = Environment.NewLine;
            Add(snippets);
        }

        internal TextList(string separator, IEnumerable<string> snippets)
        {
            snippetListSeparator = separator;
            Add(snippets);
        }

        public static TextList New(IEnumerable<string> snippets)
        {
            return new TextList(snippets);
        }

        public static TextList New(string separator, IEnumerable<string> snippets)
        {
            return new TextList(separator, snippets);
        }

        private void Add(IEnumerable<string> snippets)
        {
            textBlocks.AddRange(snippets.Select(Text.New));
        }

        public string Format(int indentLevel = 0)
        {
            return string.Join(snippetListSeparator, textBlocks.Select(snippet => snippet.Format(indentLevel)));
        }
    }
}
