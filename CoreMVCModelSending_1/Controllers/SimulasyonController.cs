using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_1.Controllers
{
    public class SimulasyonController : Controller
    {
        public IActionResult Index()
        {
            return View();

            /*return View("deneme") =>>> Artık View içinde Simulasyon klasöründe Index diye bir şey aramaz.deneme diye arar.Ancak bir 
            View in aranması bu şekilde standart değildir.Adı nasıl verildiyse (burada Index) diye aranır.
            View metodu içerisine bir action metodu verilmeden çağırıldığı zaman verilen o action ile aynı isimde View döndürme 
            görevine sahiptir.Ancak bir View metoduna explicit bir şekilde (açıkça) string bir tipte arguman verilirse o zaman isimde
            bir isimde View döndürmeye çalışır.*/

            /*View("Deneme") objectoverload mı ? string overload mı çalışır? açık olarak yazıldığı için string overload çalışır*/

            /*View("Deneme" as object) model olarak göndermek istersek veriyi bu şekilde gönderilir. */
        }
    }
}
