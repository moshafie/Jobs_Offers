using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebApplication1.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            creatdefualtuserandrole();
        }
        public void creatdefualtuserandrole()
        {
            var rolemaneger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var usermaneger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            IdentityRole role = new IdentityRole();
            if (!rolemaneger.RoleExists("Admins"))
            {
                role.Name = "Admins";
                rolemaneger.Create(role);
                ApplicationUser user =new  ApplicationUser();
                user.Email = "mshafie.developer@yahoo.com";
                user.UserName = "mshafie.developer@yahoo.com";
                var chek = usermaneger.Create(user, "Mohamed.010");
                if (chek.Succeeded)
                {
                    usermaneger.AddToRole(user.Id, "Admins");
                }
            }

        }
    }
}
