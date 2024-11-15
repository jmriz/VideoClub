using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace VideoClub.Module.NoMapeados
{
    [DomainComponent]
    
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).

    public class vcAgregarGeneroPeliculas 
    {
        
        public vcAgregarGeneroPeliculas()
        {
            this.GeneroElegido = string.Empty;
        }
        [XafDisplayName("Genero de la pelicula"), ToolTip("Escribe el genero que desea agregar al catalogo")]

        public string GeneroElegido
        {
            get; set;
        }   
    }
}