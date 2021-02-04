using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using EntityFrameworkCalismalari.MvcWebUI.Models;
using EntityFrameworkCalismalari.MvcWebUI.Models.Entity;
using EntityFrameworkCalismalari.MvcWebUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EntityFrameworkCalismalari.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult NewProduct()
        {
            NorthwndContext ctx = new NorthwndContext();


            //NewProductVm vm = new NewProductVm(); 

            //vm.Categories= ctx.Categories.ToList();
            //vm.Suppliers= ctx.Suppliers.ToList();
            //-----------------------------------------
            NewProductVm vm = new NewProductVm();
            vm.Categories = ctx.Categories.Select(cat => new SelectListItem()
            {
                Text = cat.CategoryName,
                Value=cat.CategoryID.ToString()
            }).ToList();

            vm.Categories.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            vm.Suppliers = ctx.Suppliers.Select(sup => new SelectListItem()
            {
                Text = sup.CompanyName,
                Value = sup.SupplierID.ToString()
            }).ToList();
            vm.Suppliers.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });


            return View(vm);
        }
        [HttpPost]
        public IActionResult NewProduct(Product product)
        {
            NorthwndContext ctx = new NorthwndContext();

            ctx.Products.Add(product); //insert Products(.....) values(....)
            ctx.SaveChanges();

            
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            NorthwndContext ctx = new NorthwndContext();
            ProductEditVm vm = new ProductEditVm();

            vm.ProducttoEdit= ctx.Products.SingleOrDefault(prd => prd.ProductID == id);

            vm.Categories = ctx.Categories.Select(cat => new SelectListItem()
            {
                Text = cat.CategoryName,
                Value = cat.CategoryID.ToString(),
                Selected=cat.CategoryID==vm.ProducttoEdit.CategoryId
            }).ToList();

            vm.Categories.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            vm.Suppliers = ctx.Suppliers.Select(sup => new SelectListItem()
            {
                Text = sup.CompanyName,
                Value = sup.SupplierID.ToString(),
                Selected = sup.SupplierID == vm.ProducttoEdit.SupplierID
            }).ToList();
            vm.Suppliers.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            return View(vm);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            NorthwndContext ctx = new NorthwndContext();

            Product prdToUpdate =ctx.Products.SingleOrDefault(prd => prd.ProductID == product.ProductID);

            prdToUpdate.CategoryId = product.CategoryId;
            prdToUpdate.Discontinued = product.Discontinued;
            prdToUpdate.ProductName = product.ProductName;
            prdToUpdate.QuantityPerUnit = product.QuantityPerUnit;
            prdToUpdate.SupplierID = product.SupplierID;
            prdToUpdate.UnitPrice = product.UnitPrice;

            ctx.SaveChanges();


            return RedirectToAction("Index","Home");

        }


        public IActionResult Delete(int id)
        {
            NorthwndContext ctx = new NorthwndContext();
            Product productToDelete=ctx.Products.SingleOrDefault(prd => prd.ProductID == id);


            return View(productToDelete);
        }     
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            NorthwndContext ctx = new NorthwndContext();
            Product pr = ctx.Products.SingleOrDefault(prd => prd.ProductID == product.ProductID);

            ctx.Products.Remove(pr);
            ctx.SaveChanges();
            return RedirectToAction("Index","Home");
        }

    }
}