
namespace assignment5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customer_list = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.mail_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_list
            // 
            this.customer_list.FormattingEnabled = true;
            this.customer_list.ItemHeight = 25;
            this.customer_list.Location = new System.Drawing.Point(26, 77);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(715, 379);
            this.customer_list.TabIndex = 0;
            this.customer_list.SelectedIndexChanged += new System.EventHandler(this.customer_list_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phone_lbl);
            this.groupBox1.Controls.Add(this.mail_lbl);
            this.groupBox1.Controls.Add(this.address_lbl);
            this.groupBox1.Controls.Add(this.name_lbl);
            this.groupBox1.Location = new System.Drawing.Point(779, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Details";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Location = new System.Drawing.Point(6, 278);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(59, 25);
            this.phone_lbl.TabIndex = 3;
            this.phone_lbl.Text = "label4";
            // 
            // mail_lbl
            // 
            this.mail_lbl.AutoSize = true;
            this.mail_lbl.Location = new System.Drawing.Point(6, 165);
            this.mail_lbl.Name = "mail_lbl";
            this.mail_lbl.Size = new System.Drawing.Size(59, 25);
            this.mail_lbl.TabIndex = 2;
            this.mail_lbl.Text = "label3";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Location = new System.Drawing.Point(7, 83);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(59, 25);
            this.address_lbl.TabIndex = 1;
            this.address_lbl.Text = "label2";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(7, 43);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(59, 25);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "label1";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(87, 471);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(142, 48);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(281, 471);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(142, 48);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(480, 471);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(142, 48);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 531);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customer_list);
            this.Name = "MainForm";
            this.Text = "Customer Register by Benjamin Hini";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox customer_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label mail_lbl;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}

