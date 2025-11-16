public class FotoModel
{
    public int Id { get; set; }
    public string Ruta { get; set; } = string.Empty;
    public int SesionId { get; set; }

    // ESTA ES LA QUE TE FALTA
    public int AlbumId { get; set; }
}
