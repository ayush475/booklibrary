// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
//
// app.MapGet("/", () => "Hello World!");
//
// app.Run();
using Bookepub;
using Bookepub.Data;
// using Bookepub.Repositories.GenericRepositories;
// using Bookepub.Repositories.SpecificRepositories.ActivityRepositories;
// using Bookepub.Repositories.SpecificRepositories.BeneficiaryFYActivityRepository;
// using Bookepub.Repositories.SpecificRepositories.BeneficiaryRepositories;
// using Bookepub.Repositories.SpecificRepositories.GroupFYActivityRepositories;
// using Bookepub.Repositories.SpecificRepositories.GroupRepositories;
// using Bookepub.Repositories.SpecificRepositories.IncidentFYActivityRepositories;
// using Bookepub.Repositories.SpecificRepositories.IncidentRepositories;
// using Bookepub.Repositories.SpecificRepositories.PhaseRepositories;
// using Bookepub.Repositories.SpecificRepositories.SectorRepositories;
// using Bookepub.Repositories.SpecificRepositories.UserRepositories;
// using Bookepub.Repositories.SpecificRepositories.FiscalYearRepositories;
// using Bookepub.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder ( args );

// Configure the DbContext with the connection string
builder.Services.AddDbContext<BookepubContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookepubContext") ??
                         throw new InvalidOperationException("Connection string 'BookepubContext' not found.")));

// BasePageModel.APIKey = builder.Configuration.GetSection ( "EnvironmentSettings:APIKey" ).Value;

// Configure CORS policy
builder.Services.AddCors ( options =>
{
    options.AddPolicy ( "CorsPolicy",
        policyBuilder => policyBuilder
            .AllowAnyMethod ( )
            .AllowAnyHeader ( )
            .AllowCredentials ( ) );
} );

builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor> ( );
// Add services to the container.
builder.Services.AddControllers ( );
builder.Services.AddEndpointsApiExplorer ( );
builder.Services.AddSwaggerGen ( );

// Register IGenericRepositories with its implementation
// builder.Services.AddScoped<IGenericRepositories, GenericRepositories>();
// builder.Services.AddScoped(typeof(IGenericSearchRepository<>), typeof(GenericSearchRepository<>));
// builder.Services.AddScoped<IGroupFYActivityRepositories, GroupFYActivityRepositories> ( );
// builder.Services.AddScoped<IGroupRepositories, GroupRepositories> ( );
// builder.Services.AddScoped<IUserRepositories, UserRepositories> ( );
//
// builder.Services.AddScoped<IIncidentRepositories, IncidentRepositories> ( );
// builder.Services.AddScoped<IBeneficiaryFYActivityRepositories, BeneficiaryFYActivityRepositories> ( );
// builder.Services.AddScoped<ISectorRepositories, SectorRepositories> ( );
// builder.Services.AddScoped<IFiscalYearRepositories, FiscalYearRepositories> ( );
// builder.Services.AddScoped<IPhaseRepositories, PhaseRepositories> ( );
// builder.Services.AddScoped<IActivityRepositories, ActivityRepositories> ( );
// builder.Services.AddScoped<IBeneficiaryRepositories, BeneficiaryRepositories> ( );
// builder.Services.AddScoped<IIncidentFYActivityRepositories, IncidentFYActivityRepositories> ( );

// Configure AutoMapper
// builder.Services.AddAutoMapper ( AppDomain.CurrentDomain.GetAssemblies ( ) );

// Register AutoMapper and add the profile
// builder.Services.AddAutoMapper ( typeof ( MappingProfile ) );

var app = builder.Build ( );

if (app.Environment.IsDevelopment ( ))
    {
    app.UseSwagger ( );
    app.UseSwaggerUI ( );
    }

app.UseHttpsRedirection ( );

app.UseRouting ( ); // Ensure UseRouting is called before UseAuthorization and UseCors

// Use CORS policy
app.UseCors ( options => options.AllowAnyOrigin ( ).AllowAnyMethod ( ).AllowAnyHeader ( ) );

app.UseAuthorization ( );

app.MapControllers ( );

app.Run ( );