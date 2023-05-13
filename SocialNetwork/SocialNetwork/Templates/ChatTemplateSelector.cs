using SocialNetwork.ModelsView;
using SocialNetwork.Services;
using SocialNetwork.Views.Partial;
using Xamarin.Forms;

namespace SocialNetwork.Templates
{
    public class ChatTemplateSelector : DataTemplateSelector
    {
        private DataTemplate IncomingDataTemplate { get; }

        private DataTemplate OutgoingDataTemplate { get; }

        public ChatTemplateSelector()
        {
            IncomingDataTemplate = new DataTemplate(typeof(IncomingMessageTemplate));
            OutgoingDataTemplate = new DataTemplate(typeof(OutgoingMessageTemplate));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var senderId = ((MessageDto)item).SenderId;
            var myId = MessagesMockDataStore.MyId;
            return senderId == myId
                ? OutgoingDataTemplate
                : IncomingDataTemplate;
        }
    }
}