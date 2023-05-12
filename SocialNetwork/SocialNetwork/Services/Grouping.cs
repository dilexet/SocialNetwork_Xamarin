using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SocialNetwork.Services
{
    public class Grouping<TK, T> : ObservableCollection<T>
    {
        public TK Date { get; private set; }

        public Grouping(TK date, IEnumerable<T> items)
        {
            Date = date;
            foreach (T item in items)
                Items.Add(item);
        }
    }
}