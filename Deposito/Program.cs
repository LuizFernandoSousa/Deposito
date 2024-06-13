using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Deposito.Shared.Data.Data;
using DepositoDeBebidas.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connString = builder.Configuration.GetConnectionString("DepositoConnection");



// =============  Clients  =========================
//builder.Services.AddDbContext<SupplierDbContext>(options =>
//    options.UseSqlServer(connString, b => b.MigrationsAssembly("Deposito")));

//// =============  Clients  =========================
//builder.Services.AddDbContext<ClientsDbContext>(options =>
//    options.UseSqlServer(connString, b => b.MigrationsAssembly("Deposito")));

////==============  Product  =====================================
//builder.Services.AddDbContext<ProductDbContext>(opts => 
//    opts.UseSqlServer(connString, b => b.MigrationsAssembly("Deposito")));


//=================  Users  ============================
//builder.Services.AddDbContext<DepositoDbContext>(options =>
//    options.UseSqlServer(connString, b => b.MigrationsAssembly("Deposito")));

//builder.Services
//    .AddIdentity<Users, IdentityRole>()
//    .AddEntityFrameworkStores<DepositoDbContext>()
//    .AddDefaultTokenProviders();
//================= Users ===============================
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//builder.Services.AddScoped<UserServices>();
//builder.Services.AddScoped<TokenService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new
    Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("9382y92ubnduidwhidusbcuiui2bdh8203d")),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero
    };


});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
