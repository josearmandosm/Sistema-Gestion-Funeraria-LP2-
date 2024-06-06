namespace Sistema_Gestion_Funeraria__LP2_.Models.DTOs.Categorias
{
    public class CategoriaUpdateDTO
    {
        public int IdCategoria { get; set; }

        public string Nombre { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public string TotalCobertura { get; set; } = null!;

    }
}
