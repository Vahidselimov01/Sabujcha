using Microsoft.AspNetCore.Mvc;
using Sabujcha.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Sabujcha.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Sabujcha.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HeaderVM headerVM = new HeaderVM
            {
                HeaderNavs = await dbContext.HeaderNavs.ToListAsync(),
                CatagoryNames=await dbContext.CatagoryNames.ToListAsync(),
                HeaderDropNames=await dbContext.NavDropNames.ToListAsync(),
                HeaderCatagorys=await dbContext.HeaderCatagorys.ToListAsync(),
            };
            return View(headerVM);

            
            
        }
       
      
    }
}
