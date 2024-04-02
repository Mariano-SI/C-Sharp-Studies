using System;

namespace Cap09_EnumeracoesEComposicao.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
