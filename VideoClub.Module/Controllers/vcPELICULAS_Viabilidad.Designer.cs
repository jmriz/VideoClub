namespace VideoClub.Module.Controllers
{
    partial class vcPELICULAS_Viabilidad
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
            this.popupPELICULAS_VisibleInvisible = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // popupPELICULAS_VisibleInvisible
            // 
            this.popupPELICULAS_VisibleInvisible.Caption = "Visible / Invisible";
            this.popupPELICULAS_VisibleInvisible.ConfirmationMessage = null;
            this.popupPELICULAS_VisibleInvisible.Id = "popupPELICULAS_VisibleInvisible";
            this.popupPELICULAS_VisibleInvisible.TargetObjectType = typeof(VideoClub.Module.BusinessObjects.VideoClub.Peliculas);
            this.popupPELICULAS_VisibleInvisible.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.popupPELICULAS_VisibleInvisible.ToolTip = null;
            this.popupPELICULAS_VisibleInvisible.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.popupPELICULAS_VisibleInvisible.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.popupPELICULAS_VisibleInvisible_Execute);
            // 
            // vcPELICULAS_Viabilidad
            // 
            this.Actions.Add(this.popupPELICULAS_VisibleInvisible);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction popupPELICULAS_VisibleInvisible;
    }
}
