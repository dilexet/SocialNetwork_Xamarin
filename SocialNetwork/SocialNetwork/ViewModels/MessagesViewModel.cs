using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SocialNetwork.Models;
using SocialNetwork.ModelsView;
using SocialNetwork.Services;

namespace SocialNetwork.ViewModels
{
    public class MessagesViewModel : INotifyPropertyChanged
    {
        public IEnumerable<MessageDto> Messages;

        public MessagesViewModel()
        {
            var messagesMockDataStore = new MessagesMockDataStore();
            Messages = messagesMockDataStore.GetMessages();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}