using DataAccessLayer;
using Models;
using Models.Helpers;

namespace BusinessLogicLayer
{
    public class BoxService
    {
        private readonly DataContext _context;

        private readonly BoxHelper _boxHelper;

        public BoxService(DataContext context, BoxHelper boxHelper)
        {
            _context = context;
            _boxHelper = boxHelper;
        }

        // CRUD

        // Get
        public async Task<List<Box>> GetAsync()
        {
            List<Box> result = _boxHelper.GetBoxes();
            return result;
        }

    }
}