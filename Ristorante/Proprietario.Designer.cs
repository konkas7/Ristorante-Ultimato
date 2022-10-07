namespace Ristorante
{
    partial class Proprietario
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
            this.label1 = new System.Windows.Forms.Label();
            this.addbox = new System.Windows.Forms.Button();
            this.editbox = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.Button();
            this.viewbox = new System.Windows.Forms.Button();
            this.deletebox = new System.Windows.Forms.Button();
            this.recoverbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proprietario";
            // 
            // addbox
            // 
            this.addbox.BackColor = System.Drawing.Color.White;
            this.addbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbox.Location = new System.Drawing.Point(35, 111);
            this.addbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addbox.Name = "addbox";
            this.addbox.Size = new System.Drawing.Size(213, 47);
            this.addbox.TabIndex = 1;
            this.addbox.Text = "Aggiungi";
            this.addbox.UseVisualStyleBackColor = false;
            this.addbox.Click += new System.EventHandler(this.addbox_Click);
            // 
            // editbox
            // 
            this.editbox.BackColor = System.Drawing.Color.White;
            this.editbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbox.Location = new System.Drawing.Point(256, 111);
            this.editbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editbox.Name = "editbox";
            this.editbox.Size = new System.Drawing.Size(213, 47);
            this.editbox.TabIndex = 2;
            this.editbox.Text = "Modifica";
            this.editbox.UseVisualStyleBackColor = false;
            this.editbox.Click += new System.EventHandler(this.editbox_Click);
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.White;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(477, 111);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(213, 47);
            this.searchbox.TabIndex = 3;
            this.searchbox.Text = "Ricerca";
            this.searchbox.UseVisualStyleBackColor = false;
            this.searchbox.Click += new System.EventHandler(this.searchbox_Click);
            // 
            // viewbox
            // 
            this.viewbox.BackColor = System.Drawing.Color.White;
            this.viewbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbox.Location = new System.Drawing.Point(35, 165);
            this.viewbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewbox.Name = "viewbox";
            this.viewbox.Size = new System.Drawing.Size(213, 47);
            this.viewbox.TabIndex = 5;
            this.viewbox.Text = "Visualizza";
            this.viewbox.UseVisualStyleBackColor = false;
            this.viewbox.Click += new System.EventHandler(this.viewbox_Click);
            // 
            // deletebox
            // 
            this.deletebox.BackColor = System.Drawing.Color.White;
            this.deletebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebox.Location = new System.Drawing.Point(256, 165);
            this.deletebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletebox.Name = "deletebox";
            this.deletebox.Size = new System.Drawing.Size(213, 47);
            this.deletebox.TabIndex = 6;
            this.deletebox.Text = "Elimina";
            this.deletebox.UseVisualStyleBackColor = false;
            this.deletebox.Click += new System.EventHandler(this.deletebox_Click);
            // 
            // recoverbox
            // 
            this.recoverbox.BackColor = System.Drawing.Color.White;
            this.recoverbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverbox.Location = new System.Drawing.Point(477, 165);
            this.recoverbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recoverbox.Name = "recoverbox";
            this.recoverbox.Size = new System.Drawing.Size(213, 47);
            this.recoverbox.TabIndex = 7;
            this.recoverbox.Text = "Recupera";
            this.recoverbox.UseVisualStyleBackColor = false;
            this.recoverbox.Click += new System.EventHandler(this.recoverbox_Click);
            // 
            // Proprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(731, 236);
            this.Controls.Add(this.recoverbox);
            this.Controls.Add(this.deletebox);
            this.Controls.Add(this.viewbox);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.editbox);
            this.Controls.Add(this.addbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(749, 283);
            this.MinimumSize = new System.Drawing.Size(749, 283);
            this.Name = "Proprietario";
            this.Text = "Ristorante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Proprietario_FormClosing);
            this.Load += new System.EventHandler(this.Proprietario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbox;
        private System.Windows.Forms.Button editbox;
        private System.Windows.Forms.Button searchbox;
        private System.Windows.Forms.Button viewbox;
        private System.Windows.Forms.Button deletebox;
        private System.Windows.Forms.Button recoverbox;
    }
}