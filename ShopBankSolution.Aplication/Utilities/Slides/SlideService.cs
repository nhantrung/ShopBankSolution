using ShopBankSolution.Application.System.Roles;
using ShopBankSolution.Data.Entities;
using ShopBankSolution.ViewModels.System.Roles;
using ShopBankSolution.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBankSolution.Data.EntitiFranework;

namespace ShopBankSolution.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly ShopBankDBContext _context;

        public SlideService(ShopBankDBContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}