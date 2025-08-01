/*CREATE TABLE [IM253E06Prestamo] (
    [Id] [uniqueidentifier] NOT NULL,
    [UsuarioId] [uniqueidentifier] NOT NULL,
    [LibroId] [uniqueidentifier] NOT NULL,
    [FechaPrestamo] [smalldatetime] NOT NULL,
    [FechaDevolucion] [smalldatetime] NULL,

    CONSTRAINT PK_IM253E06Prestamo PRIMARY KEY ([Id]),
    CONSTRAINT FK_IM253E06Prestamo_IM253E06Usuario FOREIGN KEY ([UsuarioId]) REFERENCES [IM253E00Usuario] ([Id]),
    CONSTRAINT FK_IM253E06Prestamo_IM253E06Libro FOREIGN KEY ([LibroId]) REFERENCES [IM253E00Libro] ([Id])
);*/
namespace Domain;
public class IM253E06Prestamo
{
    public Guid Id { get; set; }
    public Guid UsuarioId { get; set; }
    public Guid LibroId { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime? FechaDevolucion { get; set; }

    // Propiedades de navegación opcionales
    public IM253E06Usuario? Usuario { get; set; }
    public IM253E06Libro? Libro { get; set; }
}