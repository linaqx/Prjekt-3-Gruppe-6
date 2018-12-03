namespace Projekt_3___Desktop
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbBoxGenre = new System.Windows.Forms.ComboBox();
            this.cbBoxCountry = new System.Windows.Forms.ComboBox();
            this.cbBoxLanguage = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblStoryline = new System.Windows.Forms.Label();
            this.lblFilmingLocation = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.txtStoryline = new System.Windows.Forms.TextBox();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.cbBoxFilmingLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbBoxGenre
            // 
            this.cbBoxGenre.FormattingEnabled = true;
            this.cbBoxGenre.Location = new System.Drawing.Point(234, 116);
            this.cbBoxGenre.Name = "cbBoxGenre";
            this.cbBoxGenre.Size = new System.Drawing.Size(148, 28);
            this.cbBoxGenre.TabIndex = 2;
            this.cbBoxGenre.SelectedIndexChanged += new System.EventHandler(this.cbBoxGenre_SelectedIndexChanged);
            // 
            // cbBoxCountry
            // 
            this.cbBoxCountry.FormattingEnabled = true;
            this.cbBoxCountry.Location = new System.Drawing.Point(234, 151);
            this.cbBoxCountry.Name = "cbBoxCountry";
            this.cbBoxCountry.Size = new System.Drawing.Size(148, 28);
            this.cbBoxCountry.TabIndex = 3;
            // 
            // cbBoxLanguage
            // 
            this.cbBoxLanguage.FormattingEnabled = true;
            this.cbBoxLanguage.Location = new System.Drawing.Point(234, 185);
            this.cbBoxLanguage.Name = "cbBoxLanguage";
            this.cbBoxLanguage.Size = new System.Drawing.Size(148, 28);
            this.cbBoxLanguage.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(65, 86);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(65, 116);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(65, 151);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 20);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(65, 185);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(81, 20);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "Language";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(65, 216);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(104, 20);
            this.lblReleaseDate.TabIndex = 9;
            this.lblReleaseDate.Text = "Release date";
            // 
            // lblStoryline
            // 
            this.lblStoryline.AutoSize = true;
            this.lblStoryline.Location = new System.Drawing.Point(65, 249);
            this.lblStoryline.Name = "lblStoryline";
            this.lblStoryline.Size = new System.Drawing.Size(70, 20);
            this.lblStoryline.TabIndex = 10;
            this.lblStoryline.Text = "Storyline";
            // 
            // lblFilmingLocation
            // 
            this.lblFilmingLocation.AutoSize = true;
            this.lblFilmingLocation.Location = new System.Drawing.Point(65, 280);
            this.lblFilmingLocation.Name = "lblFilmingLocation";
            this.lblFilmingLocation.Size = new System.Drawing.Size(118, 20);
            this.lblFilmingLocation.TabIndex = 11;
            this.lblFilmingLocation.Text = "Filming location";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(65, 313);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(90, 20);
            this.lblInformation.TabIndex = 12;
            this.lblInformation.Text = "Information";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(234, 84);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(148, 26);
            this.txtTitle.TabIndex = 13;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(234, 220);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(148, 26);
            this.txtReleaseDate.TabIndex = 14;
            // 
            // txtStoryline
            // 
            this.txtStoryline.Location = new System.Drawing.Point(234, 253);
            this.txtStoryline.Name = "txtStoryline";
            this.txtStoryline.Size = new System.Drawing.Size(148, 26);
            this.txtStoryline.TabIndex = 15;
            // 
            // txtInformation
            // 
            this.txtInformation.Location = new System.Drawing.Point(234, 319);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(148, 26);
            this.txtInformation.TabIndex = 17;
            // 
            // cbBoxFilmingLocation
            // 
            this.cbBoxFilmingLocation.FormattingEnabled = true;
            this.cbBoxFilmingLocation.Location = new System.Drawing.Point(234, 286);
            this.cbBoxFilmingLocation.Name = "cbBoxFilmingLocation";
            this.cbBoxFilmingLocation.Size = new System.Drawing.Size(148, 28);
            this.cbBoxFilmingLocation.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 506);
            this.Controls.Add(this.cbBoxFilmingLocation);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtStoryline);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblFilmingLocation);
            this.Controls.Add(this.lblStoryline);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbBoxLanguage);
            this.Controls.Add(this.cbBoxCountry);
            this.Controls.Add(this.cbBoxGenre);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbBoxGenre;
        private System.Windows.Forms.ComboBox cbBoxCountry;
        private System.Windows.Forms.ComboBox cbBoxLanguage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblStoryline;
        private System.Windows.Forms.Label lblFilmingLocation;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.TextBox txtStoryline;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.ComboBox cbBoxFilmingLocation;
    }
}