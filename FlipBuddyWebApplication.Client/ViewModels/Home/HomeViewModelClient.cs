using FlipBuddyWebApplication.Client.ViewModels.Abstractions;
using FlipBuddyWebApplication.Persistence.Repositories;

namespace FlipBuddyWebApplication.Client.ViewModels.Home
{
    public class HomeViewModelClient : BaseClient
    {
        public readonly UserRepository _userRepository;
        public readonly ProductRepository _productRepository;
        public readonly CategoryRepository _categoryRepository;
        public readonly ConditionRepository _conditionRepository;

        public HomeViewModelClient(UserRepository userRepository,
                                    ProductRepository productRepository,
                                    CategoryRepository categoryRepository,
                                    ConditionRepository conditionRepository) 
        {
            _userRepository = userRepository;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _conditionRepository = conditionRepository;
        }
    }
}
