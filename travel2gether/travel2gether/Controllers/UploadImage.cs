using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace travel2gether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadImage : ControllerBase
    {
      /*  [HttpPost("offerPic/{id}"), DisableRequestSizeLimit]
        public IActionResult GetImage(int id)
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "offers", "img");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    //string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");

                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
      */
        [HttpPost("offerPic"), DisableRequestSizeLimit]
        public IActionResult PostImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "offers", "img");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

            
        [HttpPut("offerPic"), DisableRequestSizeLimit]
        public IActionResult PutImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "offers", "img");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    System.IO.File.Delete(pathToSave + "/" + fileName);
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpDelete("offerPic/{id}"), DisableRequestSizeLimit]
        public IActionResult DeleteImage(int id)
        {
            try
            {
                var fileName = id + ".png";
                var folderName = Path.Combine("ClientApp", "src", "assets", "offers", "img", fileName);
                var pathFromDelete = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (System.IO.File.Exists(pathFromDelete))
                {
                    System.IO.File.Delete(pathFromDelete);
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }



        [HttpPost("offerDetail"), DisableRequestSizeLimit]
        public IActionResult PostDetails()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "offers", "txt");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpPut("offerDetail"), DisableRequestSizeLimit]
        public IActionResult PutDetail()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "offers", "txt");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    System.IO.File.Delete(pathToSave + "/" + fileName);
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpDelete("offerDetail/{id}"), DisableRequestSizeLimit]
        public IActionResult DeleteDetail(int id)
        {
            try
            {
                var fileName = id + ".txt";
                var folderName = Path.Combine("ClientApp", "src", "assets", "offers", "txt", fileName);
                var pathFromDelete = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (System.IO.File.Exists(pathFromDelete))
                {
                    System.IO.File.Delete(pathFromDelete);
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }


        [HttpPost("newsPic"), DisableRequestSizeLimit]
        public IActionResult PostNewsImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "news", "img");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }


        [HttpPut("newsPic"), DisableRequestSizeLimit]
        public IActionResult PutNewsImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "news", "img");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    System.IO.File.Delete(pathToSave + "/" + fileName);
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpDelete("newsPic/{id}"), DisableRequestSizeLimit]
        public IActionResult DeleteNewsImage(int id)
        {
            try
            {
                var fileName = id + ".png";
                var folderName = Path.Combine("ClientApp", "src", "assets", "news", "img", fileName);
                var pathFromDelete = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (System.IO.File.Exists(pathFromDelete))
                {
                    System.IO.File.Delete(pathFromDelete);
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }


        [HttpPost("domesticPic"), DisableRequestSizeLimit]
        public IActionResult PostDomesticImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "domestic", "img");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }


        [HttpPut("domesticPic"), DisableRequestSizeLimit]
        public IActionResult PutDomesticImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src", "assets", "domestic", "img");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    System.IO.File.Delete(pathToSave + "/" + fileName);
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpDelete("domesticPic/{id}"), DisableRequestSizeLimit]
        public IActionResult DeleteDomesticImage(int id)
        {
            try
            {
                var fileName = id + ".png";
                var folderName = Path.Combine("ClientApp", "src", "assets", "domestic", "img", fileName);
                var pathFromDelete = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (System.IO.File.Exists(pathFromDelete))
                {
                    System.IO.File.Delete(pathFromDelete);
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
