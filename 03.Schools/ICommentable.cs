using System.Collections.Generic;

namespace Schools
{
    public interface ICommentable
    {
        List<string> Comments { get; set; }

        void AddComment(string comment);

    }
}
