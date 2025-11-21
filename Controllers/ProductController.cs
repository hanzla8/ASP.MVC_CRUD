using Microsoft.AspNetCore.Mvc;
using ProductCrud_CodeWithPushpa.Data;
using ProductCrud_CodeWithPushpa.Models;

namespace ProductCrud_CodeWithPushpa.Controllers
{
    public class ProductController(AppDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
                return View();

            product.CreateAt = DateTime.Now;
            product.UpdateAt = DateTime.Now;
            context.Add(product);
            
            var result = context.SaveChanges();

            if (result > 0)
            {
                TempData["Message"] = "Product has been Added successfully";
                return RedirectToAction("Index");
            }
             
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = context.Products.SingleOrDefault(x => x.Id == id);

            if (product is null) return NotFound();
            return View(product);
        }


        [HttpPost]
        public IActionResult Update(Product product, int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var productFromDb = context.Products.SingleOrDefault
                (x=>x.Id == id);
            if(productFromDb == null) return NotFound();

            productFromDb.Name = product.Name;
            productFromDb.Description = product.Description;
            productFromDb.Image = product.Image;
            productFromDb.UpdateAt = DateTime.Now;

            if (context.SaveChanges() > 0)
            {
                TempData["Message"] = "Product has been Updated successfully";
                return RedirectToAction("Index");
            }

            TempData["Message"] = "Product failed to update";
            return View();
        }

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var product = context.Products.SingleOrDefault(x=> x.Id == id);
        //    if (product is null) return NotFound();

        //    return View(product);
        //}

        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var product = context.Products.SingleOrDefault(x => x.Id == id);
        //    if (product is null) return NotFound();

        //    context.Products.Remove(product);

        //    if (context.SaveChanges() > 0)
        //    {
        //        TempData["Message"] = "Product has been Deleted successfully";
        //        return RedirectToAction("Index");
        //    }

        //    TempData["Message"] = "Product Failed to Delete";
        //    return RedirectToAction("Index");
        //}


        [HttpDelete("api/products/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = context.Products.SingleOrDefault(x => x.Id == id);
            if (product is null) return NotFound();

            context.Products.Remove(product);

            if(context.SaveChanges() > 0)
            {
                return Ok(new { message = "Product deleted Successfully" });
            }

            return BadRequest(new { message = "Faild to update products" });
        }



    }
}
