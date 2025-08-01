/*
CREATE TABLE [IM253E06Libro] (
    [Id] [uniqueidentifier] NOT NULL,
    [Autor] [nvarchar] NOT NULL,
    [Editorial] [nvarchar] NULL,
    [ISBN] [nvarchar] NOT NULL,
    [Foto] [nvarchar](max) NULL,

    CONSTRAINT PK_IM253E06Libro PRIMARY KEY ([Id])
);
*/
namespace Domain;
public class IM253E06Libro
{

    public Guid Id { get; set; }
    public string Autor { get; set; } = string.Empty;
    public string? Editorial { get; set; }
    public string ISBN { get; set; } = string.Empty;
    public string? Foto { get; set; }
}