using CoreMVCModelSending_1.Models.PageVMs;
using CoreMVCModelSending_1.Models.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {


            return View("Merhaba" as object);


            //Model göndermek :Frontendde göstermek istediğimiz verileri Backendden fronttende yollamak veya frontendden backende 
            //göndermek istediğimiz verileri gönderme yoludur.
            //Bir model gönderiliyorsa karşılanmak zorunundadır.
            //Modelin karşılanması View sayfasında @model diyerek gönderdiğiniz verinin orjinal şekilde yazılması olur.
            //Model karşılandıktan sonra o ilgili modelin gösterilmesini istiyorsanız karşıladığımız modeli çağırmamız gerekir.
            //Bu da büyük @Model ile olur.
        }
        public IActionResult GetProducts() {


            List<Product> products = new List<Product>()
           {
               new(){ID=1, ProductName="Tadelle",UnitPrice=15},
               new(){ID=2, ProductName="Biskrem",UnitPrice=25},
               new(){ID=1, ProductName="Çizi",UnitPrice=35}

            };
            Category c = new()
            {
                CategoryName = "Tatlılar",
                Description = "Şekerlemeler"

            };
            /*Birden fazla veri göndereceksek pageVM klasörü açılır.İçerisine gönderilecek verilerin propertyleri yazılır.Daha sonra
             Veriyi göndereceğimiz Contoller içerindeki actiona gelinir.Orada instance alınır içerisine propertysi yazılan veriler
            inject edilir.Sonra viewImport kısmına @using CoreMVCModelSending_1.Models.PageVMs eklenir.*/
            GetProductsPageVM gppvm = new()
            {
                Products = products,
                Category = c
            };
            return View(gppvm);
        }

        /*FRONTENDEN BACKENDE VERİ GÖNDERME GET VE POST OLAYLARI*/
        public IActionResult CreateProduct() {



            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product){
            
            
            
            return View();
        }
    }
}
