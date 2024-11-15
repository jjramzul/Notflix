using Castle.DynamicProxy;
using WebApplication1.Interfaces;
namespace WebApplication1.Aspectos
{
    public class AuthInterceptor : IInterceptor
    {
        private readonly IAuthService _authService;

        public AuthInterceptor(IAuthService authService)
        {
            _authService = authService;
        }

        public void Intercept(IInvocation invocation)
        {
            if (_authService.IsAuthenticated())
            {
                invocation.Proceed();
            }
            else
            {
                throw new UnauthorizedAccessException("Usuario no autenticado. Debe iniciar sesión.");
            }
        }
    }

}
