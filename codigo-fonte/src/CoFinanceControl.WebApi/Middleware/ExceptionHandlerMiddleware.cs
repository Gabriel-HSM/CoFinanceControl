using CoFinanceControl.Application.Exeptions;

namespace CoFinanceControl.WebApi.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (DomainExeption ex)
            {
                await WriteError(context, StatusCodes.Status404NotFound, ex.Message);
            }
            catch (UsuarioNaoEncontradoException ex)
            {
                await WriteError(context, StatusCodes.Status404NotFound, ex.Message);
            }
            catch (CategoriaNaoEncontadoExeption ex)
            {
                await WriteError(context, StatusCodes.Status404NotFound, ex.Message);
            }
            catch (Exception)
            {
                await WriteError(context,StatusCodes.Status500InternalServerError, "ErroInternoDoServidor");
            }
        }

        private async Task WriteError(HttpContext context, int statusCode, string message)
        {
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "applicarion/json";
            
            await context.Response.WriteAsJsonAsync(new {
                erro = message
            });
        }
    }
}