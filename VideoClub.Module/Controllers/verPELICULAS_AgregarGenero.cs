using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace VideoClub.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class verPELICULAS_AgregarGenero : ViewController
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public verPELICULAS_AgregarGenero()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void popupPELICULAS_AgregarGenero_Params(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            NonPersistentObjectSpace objectSpace = (NonPersistentObjectSpace)Application.CreateObjectSpace(typeof(NoMapeados.vcAgregarGeneroPeliculas));
            NoMapeados.vcAgregarGeneroPeliculas parametros = objectSpace.CreateObject<NoMapeados.vcAgregarGeneroPeliculas>();

            DetailView detail = Application.CreateDetailView(objectSpace, parametros);
            detail.Caption = "Insertar un género de peliculas";
            detail.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
            e.View = detail;
        }

        private void popupPELICULAS_AgregarGeneros_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            var sesion = ((XPObjectSpace)this.ObjectSpace).Session;
            var parametros = (NoMapeados.vcAgregarGeneroPeliculas)e.PopupWindowView.SelectedObjects[0];

            if (!string.IsNullOrEmpty(parametros.GeneroElegido))
            {
                var nuevo = new BusinessObjects.VideoClub.CAT_GENEROS_PELICULAS(sesion);
                nuevo.Genero = parametros.GeneroElegido.Trim();
                nuevo.Visible = true;
                nuevo.Save();
                nuevo.Session.CommitTransaction();
                //todo: AVISAR AL USUARIO QUE TODO SALIO BIEN

                Application.ShowViewStrategy.ShowMessage($"El género {parametros.GeneroElegido} Fue insertado correctamente", InformationType.Success, 5000, InformationPosition.Top);
            }
            Frame.View.RefreshDataSource();


        }
    }
}
