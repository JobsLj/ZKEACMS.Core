/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.RepositoryPattern;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using ZKEACMS.Product.Models;
using ZKEACMS.Product.ViewModel;
using ZKEACMS.Widget;
using System.Linq;
using Easy;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ZKEACMS.Product.Service
{
    public class ProductListWidgetService : WidgetService<ProductListWidget, ProductDbContext>
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        public ProductListWidgetService(IWidgetBasePartService widgetService, IProductService productService, IProductCategoryService productCategoryService, IApplicationContext applicationContext)
            : base(widgetService, applicationContext)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
        }

        public override DbSet<ProductListWidget> CurrentDbSet
        {
            get
            {
                return DbContext.ProductListWidget;
            }
        }

        public override void Add(ProductListWidget item)
        {
            if (!item.PageSize.HasValue || item.PageSize.Value == 0)
            {
                item.PageSize = 20;
            }
            base.Add(item);
        }
        public override WidgetViewModelPart Display(WidgetBase widget, ActionContext actionContext)
        {
            ProductListWidget currentWidget = widget as ProductListWidget;
            IEnumerable<ProductEntity> products = null;
            int pageIndex = actionContext.RouteData.GetPage();
            int cate = actionContext.RouteData.GetCategory();
            var pagin = new Pagination<ProductEntity>
            {
                PageIndex = pageIndex,
                PageSize = currentWidget.PageSize ?? 20,
                OrderBy = m => m.OrderIndex
            };
            
            Expression<Func<ProductEntity, bool>> filter = null;
            if (cate != 0)
            {
                filter = m => m.IsPublish && m.ProductCategoryID == cate;
            }
            else
            {
                var ids = _productCategoryService.Get(m => m.ID == currentWidget.ProductCategoryID || m.ParentID == currentWidget.ProductCategoryID).Select(m => m.ID).ToList();
                filter = m => m.IsPublish && ids.Any(id => id == m.ProductCategoryID);
            }
            if (currentWidget.IsPageable)
            {
                products = _productService.Get(filter, pagin).ToList();
            }
            else
            {
                products = _productService.Get(filter).OrderBy(m => m.OrderIndex).ThenByDescending(m => m.ID).ToList();
            }

            var currentCategory = _productCategoryService.Get(cate == 0 ? currentWidget.ProductCategoryID : cate);
            if (currentCategory != null)
            {
                var page = actionContext.HttpContext.GetLayout().Page;
                page.Title = (page.Title ?? "") + " - " + currentCategory.Title;
            }

            return widget.ToWidgetViewModelPart(new ProductListWidgetViewModel
            {
                Products = products,
                Page = pagin,
                IsPageable = currentWidget.IsPageable,
                Columns = currentWidget.Columns,
                DetailPageUrl = currentWidget.DetailPageUrl
            });
        }
    }
}