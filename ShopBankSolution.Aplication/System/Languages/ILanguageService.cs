using ShopBankSolution.ViewModels.Common;
using ShopBankSolution.ViewModels.System.Languages;
using ShopBankSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBankSolution.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}