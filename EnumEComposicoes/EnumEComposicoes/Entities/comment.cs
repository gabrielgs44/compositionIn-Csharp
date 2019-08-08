using System;
using System.Collections.Generic;
using System.Text;

namespace EnumEComposicoes.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment(string text = null)
        {
            Text = text;
        }

    }
}
