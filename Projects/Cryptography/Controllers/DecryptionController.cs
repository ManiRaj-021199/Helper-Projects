using Microsoft.AspNetCore.Mvc;

namespace Cryptography.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DecryptionController : ControllerBase
{
    #region Publics
    [HttpGet]
    [Route("[action]")]
    public string Index()
    {
        return "Decryption";
    }
    #endregion
}