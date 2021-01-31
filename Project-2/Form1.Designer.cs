
namespace Project_2
{
    partial class Form1
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
            this.lbxProductsList = new System.Windows.Forms.ListBox();
            this.lblProductsList = new System.Windows.Forms.Label();
            this.lblProductsName = new System.Windows.Forms.Label();
            this.tbxProductsName = new System.Windows.Forms.TextBox();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxProductsList
            // 
            this.lbxProductsList.FormattingEnabled = true;
            this.lbxProductsList.Location = new System.Drawing.Point(12, 37);
            this.lbxProductsList.Name = "lbxProductsList";
            this.lbxProductsList.Size = new System.Drawing.Size(131, 186);
            this.lbxProductsList.TabIndex = 0;
            // 
            // lblProductsList
            // 
            this.lblProductsList.AutoSize = true;
            this.lblProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductsList.Location = new System.Drawing.Point(9, 17);
            this.lblProductsList.Name = "lblProductsList";
            this.lblProductsList.Size = new System.Drawing.Size(87, 17);
            this.lblProductsList.TabIndex = 1;
            this.lblProductsList.Text = "Ürün Listesi:";
            // 
            // lblProductsName
            // 
            this.lblProductsName.AutoSize = true;
            this.lblProductsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductsName.Location = new System.Drawing.Point(170, 37);
            this.lblProductsName.Name = "lblProductsName";
            this.lblProductsName.Size = new System.Drawing.Size(67, 17);
            this.lblProductsName.TabIndex = 2;
            this.lblProductsName.Text = "Ürün Adı:";
            // 
            // tbxProductsName
            // 
            this.tbxProductsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductsName.Location = new System.Drawing.Point(262, 34);
            this.tbxProductsName.Name = "tbxProductsName";
            this.tbxProductsName.Size = new System.Drawing.Size(176, 23);
            this.tbxProductsName.TabIndex = 3;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProducts.Location = new System.Drawing.Point(358, 63);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(80, 30);
            this.btnAddProducts.TabIndex = 4;
            this.btnAddProducts.Text = "Ekle";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteProducts.Location = new System.Drawing.Point(149, 193);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(107, 30);
            this.btnDeleteProducts.TabIndex = 5;
            this.btnDeleteProducts.Text = "Sil";
            this.btnDeleteProducts.UseVisualStyleBackColor = true;
            this.btnDeleteProducts.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 248);
            this.Controls.Add(this.btnDeleteProducts);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.tbxProductsName);
            this.Controls.Add(this.lblProductsName);
            this.Controls.Add(this.lblProductsList);
            this.Controls.Add(this.lbxProductsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProductsList;
        private System.Windows.Forms.Label lblProductsList;
        private System.Windows.Forms.Label lblProductsName;
        private System.Windows.Forms.TextBox tbxProductsName;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnDeleteProducts;
    }
}

