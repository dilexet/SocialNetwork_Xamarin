using System.Collections.Generic;

namespace SocialNetwork.ModelsView
{
    public class MessageGroup<T, TK> : List<TK>
    {
        public T Date { get; private set; }

        public MessageGroup(T date, IEnumerable<TK> messages) : base(messages)
        {
            Date = date;
        }
    }
}