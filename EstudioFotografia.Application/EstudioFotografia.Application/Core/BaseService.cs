using EstudioFotografia.Application.Core;

namespace EstudioFotografia.Application.Core
{
    public abstract class BaseService
    {
        protected ServiceResult<T> Ok<T>(T data, string message = "OK")
            => ServiceResult<T>.Ok(data, message);

        protected ServiceResult<T> Error<T>(string message)
            => ServiceResult<T>.Fail(message);
    }
}
