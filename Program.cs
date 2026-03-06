var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/* Comento esta linea de código para evitar el error de certificado SSL en el navegador, ya que no tengo un certificado válido para localhost
esto lo que hace es que no me perite abrir el puerto local host con http ni con https en el navegador*/

//app.UseHttpsRedirection();


app.Run();


