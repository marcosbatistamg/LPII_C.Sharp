var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");

var app = builder.Build();

app.MapGet("/", () => {
// Retorna que tá tudo funcionando
    return Results.Ok("API funcionando ...");
});

app.MapGet("/calcula/{opcao}/{valor1}/{valor2}", (int opcao, int valor1, int valor2) => {
// Envio de informações 
 int resultado;
    switch(opcao){
     case 1:
        resultado = valor1 + valor2;
        return Results.Ok(new{
            operacao = "soma",
            valor1,
            valor2,
            resultado
        });

     case 2:
     resultado = valor1 - valor2;
        return Results.Ok(new{
            operacao = "subtração",
            valor1,
            valor2,
            resultado
        });
            
     case 3:
        resultado = valor1 * valor2;
        return Results.Ok(new{
            operacao = "multiplicação",
            valor1,
            valor2,
            resultado
        });

     case 4:
        resultado = valor1 / valor2;
        return Results.Ok(new{
            operacao = "divisão",
            valor1,
            valor2,
            resultado
        });

     default:
        return Results.BadRequest("Opção inválida.");
    }
});

app.MapGet("/calcular/soma/{valor1}/{valor2}", (int valor1, int valor2) => { 
   
   int result = valor1 + valor2;

      return Results.Ok(new{
            operacao = "soma",
            valor1,
            valor2,
            result 
        });
});

app.MapGet("/calcular/subtracao/{valor1}/{valor2}", (int valor1, int valor2) => { 
   
   int result = valor1 - valor2;

      return Results.Ok(new{
            operacao = "subtração",
            valor1,
            valor2,
            result
        });
});

app.MapGet("/calcular/multiplicacao/{valor1}/{valor2}", (int valor1, int valor2) => { 
   
   int result = valor1 * valor2;

      return Results.Ok(new{
            operacao = "multiplicação",
            valor1,
            valor2,
            result 
        });
});

app.MapGet("/calcular/divisao/{valor1}/{valor2}", (int valor1, int valor2) => { 
   
   int result = valor1 / valor2;

      return Results.Ok(new{
            operacao = "divisão",
            valor1,
            valor2,
            result
        });
});

app.Run();
