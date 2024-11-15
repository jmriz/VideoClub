namespace VideoClub.Module.Controllers
{
    partial class verPELICULAS_AgregarGenero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.upPELICULAS_AgregarGenero = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // upPELICULAS_AgregarGenero
            // 
            this.upPELICULAS_AgregarGenero.AcceptButtonCaption = null;
            this.upPELICULAS_AgregarGenero.CancelButtonCaption = null;
            this.upPELICULAS_AgregarGenero.Caption = "Agregar Genero";
            this.upPELICULAS_AgregarGenero.ConfirmationMessage = null;
            this.upPELICULAS_AgregarGenero.Id = "AgregarGenerosPeliculasCatalogo";
            this.upPELICULAS_AgregarGenero.TargetObjectType = typeof(VideoClub.Module.BusinessObjects.VideoClub.Peliculas);
            this.upPELICULAS_AgregarGenero.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.upPELICULAS_AgregarGenero.ToolTip = null;
            this.upPELICULAS_AgregarGenero.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.upPELICULAS_AgregarGenero.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupPELICULAS_AgregarGenero_Params);
            this.upPELICULAS_AgregarGenero.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.popupPELICULAS_AgregarGeneros_Execute);
            // 
            // verPELICULAS_AgregarGenero
            // 
            this.Actions.Add(this.upPELICULAS_AgregarGenero);
            this.TargetObjectType = typeof(VideoClub.Module.BusinessObjects.VideoClub.Peliculas);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction upPELICULAS_AgregarGenero;
    }
}
