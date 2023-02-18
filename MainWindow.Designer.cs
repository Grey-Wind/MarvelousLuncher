namespace MarvelousLuncher
{
    partial class MainWindow
    {
        /// <summary>
        ///  必需的设计器变量.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  清理任何正在使用的资源.
        /// </summary>
        /// <param name="disposing">如果要处理托管资源，则为true;否则为false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion
    }
}