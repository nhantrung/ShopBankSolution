using ShopBankSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBankSolution.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}