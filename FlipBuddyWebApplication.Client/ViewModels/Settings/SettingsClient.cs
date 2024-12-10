using FlipBuddyWebApplication.Persistence.Repositories;

namespace FlipBuddyWebApplication.Client.ViewModels.Settings
{
    public class SettingsClient
    {
        public readonly UserRepository _userRepository;
        public SettingsClient(UserRepository userRepository) 
        {
            _userRepository = userRepository;
        }       
    }
}
