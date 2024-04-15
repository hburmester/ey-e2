using System;
using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618
public class Proveedor
{
    public int Id { get; set; }

    [Required(ErrorMessage = "La razón social es obligatoria.")]
    public string RazonSocial { get; set; }

    [Required(ErrorMessage = "El nombre comercial es obligatorio.")]
    public string NombreComercial { get; set; }

    [Required(ErrorMessage = "La identificación tributaria es obligatoria.")]
    [MaxLength(11, ErrorMessage = "La identificación tributaria debe tener 11 dígitos.")]
    public int IdentificacionTributaria { get; set; }

    [Required(ErrorMessage = "Debe ingresar un número de teléfono.")]
    [RegularExpression(@"^\d{9}$", ErrorMessage = "El número telefónico no es válido.")]
    public string NumeroTelefonico { get; set; }

    [Required(ErrorMessage = "Debe ingresar un correo electrónico.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
    public string CorreoElectronico { get; set; }

    [Required(ErrorMessage = "Debe ingresar un sitio web.")]
    [Url(ErrorMessage = "La URL del sitio web no es válida.")]
    public string SitioWeb { get; set; }

    [Required(ErrorMessage = "Debe ingresar una dirección.")]
    public string DireccionFisica { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un país.")]
    public string Pais { get; set; }

    [Required(ErrorMessage = "Debe ingresar el monto de facturación anual.")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "La facturación anual no es válida.")]
    public decimal FacturacionAnualUSD { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
    public DateTime UltimaEdicion { get; set; }
}

#pragma warning restore CS8618