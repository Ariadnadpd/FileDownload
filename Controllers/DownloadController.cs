using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FileDownload.Demo.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase 
    {
        private readonly string filePath;

        public DownloadController(string filePath) 
        {
            this.filePath = filePath;
        }
        
        [HttpGet]
        public FileContentResult Get()
        {
            /** UNA FORMA DE HACERLO
            
            var data = System.IO.File.ReadAllBytes(filePath);
            var result = new FileContentResult(data, "application/octet-stream")
            {
                // Nombre de descarga del archivo
                FileDownloadName = "File.csv"
            };
            return result;

            **/
            
            /**OTRA FORMA DE HACERLO**/

            return File (System.IO.File.ReadAllBytes(filePath),"application/octet-stream", "File.csv");
        }

    }
}