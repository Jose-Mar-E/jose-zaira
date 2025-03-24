using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

public class Productos
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? ObjectId { get; set; }  

    public string Nombre { get; set; }  
    public string Marca { get; set; }  
    public bool Disponible { get; set; }  
    public string Categoria { get; set; } 
    public decimal Precio { get; set; } 
    public bool CantidadStock { get; set; }  
    public decimal Calificacion { get; set; }
     public DateTime FechaLanzamiento { get; set; }  
    
   
}
