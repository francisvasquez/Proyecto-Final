namespace EstudioFotografia.Infrastructure.Exceptions
{
    public class EntityNotFoundException : BaseException
    {
        public EntityNotFoundException(string entity, int id)
            : base($"{entity} con ID {id} no fue encontrado.")
        {
        }
    }
}
