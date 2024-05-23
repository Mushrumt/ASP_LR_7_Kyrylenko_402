using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ASP_LR_7_Kyrylenko_402
{
    public class FileController : Controller
    {
        [HttpGet("File/DownloadFile")]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost("File/DownloadFile")]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            string content = $"Name:\t {firstName}\nSurname:\t {lastName}";
            byte[] byteArray = Encoding.UTF8.GetBytes(content);

            return File(byteArray, "text/plain", fileName + ".txt");
        }
    }
}
