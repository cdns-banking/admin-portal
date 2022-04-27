using System.Security.Cryptography;

namespace admin_portal.BusinessLayer
{
    public class AdminUserLogic : IAdminUser
    {
        private readonly DataContext _dataContext;
        public AdminUserLogic(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Admin> Register(Admin request)
        {
            AdminUser admin =  new AdminUser();

            Admin admin1 = new Admin();

            CreatePasswordHash(request.Password, out var passwordHash, out var passwordSalt);

            admin.AdminName = request.AdminName;
            admin.Password = request.Password;
            admin.PhoneNo = request.PhoneNo;
            admin.EmailID = request.EmailID;

            await _dataContext.Admins.AddAsync(admin);
            await _dataContext.SaveChangesAsync();

            admin1.AdminName = request.AdminName;   
            admin1.EmailID = request.EmailID;   
            admin1.PhoneNo = request.PhoneNo;

            return admin1;
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }


        }

    }
}
