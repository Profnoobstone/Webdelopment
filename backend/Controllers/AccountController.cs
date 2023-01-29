using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly UserManager<Gebruiker> _userManager;
    private readonly SignInManager<Gebruiker> _signInManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AccountController(UserManager<Gebruiker> userManager, SignInManager<Gebruiker> signInManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
    }

    [HttpPost]
    [Route("registreer")]
    public async Task<ActionResult<IEnumerable<Show>>> Registreer([FromBody] Gebruiker gebruiker)
    {
        var resultaat = await _userManager.CreateAsync(gebruiker, gebruiker.Wachtwoord);

        if(!(await _roleManager.RoleExistsAsync("DefaultAuth")))
            await _roleManager.CreateAsync(new IdentityRole("DefaultAuth"));

        resultaat = await _userManager.AddToRoleAsync(gebruiker,"DefaultAuth");
        return !resultaat.Succeeded ? new BadRequestObjectResult(resultaat) : StatusCode(201);
    }

[HttpPost("login")]
public async Task<IActionResult> Login([FromBody] GebruikerLogin gebruikerLogin)
{
    var _user = await _userManager.FindByNameAsync(gebruikerLogin.UserName);
    if (_user != null)
        if (await _userManager.CheckPasswordAsync(_user, gebruikerLogin.Password))
        {
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("awef98awef978haweof8g7aw789efhh789awef8h9awh89efh89awe98f89uawef9j8aw89hefawef"));

            var signingCredentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, _user.UserName) };
            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
                claims.Add(new Claim(ClaimTypes.Role, role));
            var tokenOptions = new JwtSecurityToken
            (
                issuer: "https://localhost:7214",
                audience: "https://localhost:7214",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signingCredentials
            );
            return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(tokenOptions), roles });
        }

    return Unauthorized();
}
}

public class GebruikerLogin
{
    [Required(ErrorMessage = "Username is required")]
    public string? UserName { get; init; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; init; }
}