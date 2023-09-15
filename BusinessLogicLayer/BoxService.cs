using DataAccessLayer;
using Interfaces;
using Models;
using Models.Helpers;

namespace BusinessLogicLayer
{
    public class BoxService : IBoxService
    {
        private readonly DataContext _context;

        private readonly IBoxHelper _boxHelper;

        public BoxService(DataContext context, IBoxHelper boxHelper)
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