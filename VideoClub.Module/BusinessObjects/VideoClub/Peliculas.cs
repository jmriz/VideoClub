using System;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace VideoClub.Module.BusinessObjects.VideoClub
{
    [DefaultClassOptions]
    [NavigationItem("VideoClub")]
    //[XafDisplayName("PELICULAS")]
    [DefaultProperty("Titulo")]

    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Peliculas : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Peliculas(Session session)
            : base(session)
        {
        }

        #region Métodos redefinidos

        #endregion Métodos redefinidos

        #region Propiedades

        private string _Titulo;
        [XafDisplayName("Titulo"), ToolTip("Título de la película")]
        [RuleRequiredField]  // Campo texto obligatorio

        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        public string Titulo
        {
            get { return _Titulo; }
            set { SetPropertyValue(nameof(Titulo), ref _Titulo, value); }
        }

        private string _Sinopsis;
        [XafDisplayName("Sinopsis"), ToolTip("Sinopsis de la película")]
        [Size(300)]
        
        public string Sinopsis
        {
            get { return _Sinopsis; }
            set { SetPropertyValue(nameof(Sinopsis), ref _Sinopsis, value); }
        }

        private DateTime _FechaDeEstreno;
        [XafDisplayName("Fecha de Estreno"), ToolTip("Fecha de estreno de la película")]
       
        public DateTime FechaDeEstreno
        {
            get { return _FechaDeEstreno; }
            set { SetPropertyValue(nameof(FechaDeEstreno), ref _FechaDeEstreno, value); }
        }

        private decimal _Precio;
        [XafDisplayName("Precio"), ToolTip("Precio de la película")]
        
        public decimal Precio
        {
            get { return _Precio; }
            set { SetPropertyValue(nameof(Precio), ref _Precio, value); }
        }

        private FileData _Pelicula;
        [XafDisplayName("Película")]
        [VisibleInListView(false)]        // Oculta la vista

        public FileData Pelicula
        {
            get { return _Pelicula; }
            set { SetPropertyValue(nameof(Pelicula), ref _Pelicula, value); }
        }


        private bool _Visible;
        [XafDisplayName("Visible")]
        
        public bool Visible
        {
            get { return _Visible; }
            set { SetPropertyValue(nameof(Visible), ref _Visible, value); }
        }

        #endregion Propiedades

        #region Colecciones

        #endregion Colecciones

        #region Asociaciones 

        private CAT_GENEROS_PELICULAS _Cat_Genero;
        [XafDisplayName("Género"), ToolTip("Género de la película")]
        [DataSourceCriteria("Visible = true")]

        public CAT_GENEROS_PELICULAS Cat_Genero
        {
            get { return _Cat_Genero; }
            set { SetPropertyValue(nameof(Cat_Genero), ref _Cat_Genero, value); }
        }

        // Viene de Enumeraciones

        private EN_TIPO_PELICULA _TipoDePelicula;
        [XafDisplayName("Tipo de Pelicula")]

        public EN_TIPO_PELICULA TipoDePelicula
        {
            get { return _TipoDePelicula; }
            set { SetPropertyValue(nameof(TipoDePelicula), ref _TipoDePelicula, value); }
        }

        #endregion  Asociaciones


        #region Metodos

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.Visible = true;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        /* COMENTADO PARA REALIZAR LA PRACTICA "DEVEXPRESS 09 - Crear un ViewController simple con selección de múltiples registros"

        //AÑADIR BOTON

        //[Action(Caption = "Visible/Invisible", ConfirmationMessage = "¿Estas seguro? ", ImageName = "Attention", AutoCommit = true)]
        [Action(Caption = "Visible/Invisible", ConfirmationMessage = "¿Estas seguro? ", AutoCommit = true)]

        public void Visibilidad()
        {
            this.Visible = !this.Visible;
        }

         */

        #endregion Metodos

        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}