using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabujcha.DAL;
using Sabujcha.ViewModels;
using System.Threading.Tasks;

namespace Sabujcha.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext context;

        public FooterViewComponent(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterVM footerVM = new FooterVM
            {
                FooterContents = await context.FooterContents.ToListAsync(),
                FooterTitles = await context.FooterTitles.ToListAsync()

            };
            return View(footerVM);


        }
    }
}
