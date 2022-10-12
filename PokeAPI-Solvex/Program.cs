var builder = WebApplication.CreateBuilder(args);
//var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//const string corsPolicyName = "ApiCORS";

/*builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicyName, policy =>
    {
        policy.WithOrigins("https://localhost:7192");
    });
});*/

/*builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins(
                "https://localhost:3000"
                );
        });
    //options.AddPolicy(name: MyAllowSpecificOrigins,
    //                  policy =>
    //                  {
    //                      policy.WithOrigins("https://localhost:42494",
    //                                          "https://localhost:7192",
    //                                          "https://localhost:44300")
    //                      .AllowAnyHeader()
    //                      .AllowAnyMethod();
    //                  });
});*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());

//app.UseCors(corsPolicyName);

app.UseStaticFiles();

//app.UseCors(x => x
//                .AllowAnyMethod()
//                .AllowAnyHeader()
//                .AllowAnyOrigin());

app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) // allow any origin
                                                        //.WithOrigins("https://localhost:44351")); // Allow only this origin can also have multiple origins separated with comma
                    .AllowCredentials()); // allow credentials

app.UseAuthentication();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
