namespace admin_portal.Interface
{
    public interface IAdminUser
    {
        public Task<Admin> Register(Admin request);
    }
}
