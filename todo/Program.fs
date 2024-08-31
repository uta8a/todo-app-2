module todo.Program
open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting

[<EntryPoint>]
let main args =
    let builder = WebApplication.CreateBuilder(args)
    let app = builder.Build()

    app.UseStaticFiles() |> ignore;
    app.MapGet("/hoge", Func<string>(fun () -> "Hello World!")) |> ignore

    app.Run()

    0 // Exit code
