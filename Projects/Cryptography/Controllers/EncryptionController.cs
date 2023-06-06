using Microsoft.AspNetCore.Mvc;

namespace Cryptography.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EncryptionController : ControllerBase
{
    #region Publics
    [HttpGet]
    [Route("[action]")]
    public string Index()
    {
        return "Encryption";
    }
    #endregion
}