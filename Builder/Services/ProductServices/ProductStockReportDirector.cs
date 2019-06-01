using Builder.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Services.ProductServices
{
    public class ProductStockReportDirector
    {
        private IProductStockReportBuilder _productStockReportBuilder;

        public ProductStockReportDirector(IProductStockReportBuilder productStockReportBuilder)
        {
            _productStockReportBuilder = productStockReportBuilder ?? throw new ArgumentNullException(nameof(productStockReportBuilder));
        }

        public void BuilReport()
        {
            _productStockReportBuilder
            .BuildHeader()
            .BuildBody()
            .BuildFooter();
        }

    }
}
