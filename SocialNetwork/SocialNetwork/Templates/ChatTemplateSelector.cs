using SocialNetwork.ModelsView;
using SocialNetwork.Services;
using SocialNetwork.Views.Cells;
using Xamarin.Forms;

namespace SocialNetwork.Templates
{
    public class ChatTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate _incomingDataTemplate;
        private readonly DataTemplate _outgoingDataTemplate;

        public ChatTemplateSelector()
        {
            _incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
            _outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var senderId = ((MessageDto)item).SenderId;
            var myId = MessagesMockDataStore.MyId;
            return senderId == myId
                ? _outgoingDataTemplate
                : _incomingDataTemplate;
        }
    }
}