namespace RobotAssistant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvDoctor = new System.Windows.Forms.ListView();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnRemoveDoctor = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Information System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doctor";
            // 
            // lvDoctor
            // 
            this.lvDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDoctor.HideSelection = false;
            this.lvDoctor.Location = new System.Drawing.Point(30, 156);
            this.lvDoctor.Name = "lvDoctor";
            this.lvDoctor.Size = new System.Drawing.Size(902, 926);
            this.lvDoctor.TabIndex = 4;
            this.lvDoctor.UseCompatibleStateImageBehavior = false;
            this.lvDoctor.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(956, 156);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(97, 41);
            this.btnAddDoctor.TabIndex = 5;
            this.btnAddDoctor.Text = "Add ";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveDoctor
            // 
            this.btnRemoveDoctor.Location = new System.Drawing.Point(956, 267);
            this.btnRemoveDoctor.Name = "btnRemoveDoctor";
            this.btnRemoveDoctor.Size = new System.Drawing.Size(97, 41);
            this.btnRemoveDoctor.TabIndex = 6;
            this.btnRemoveDoctor.Text = "Remove";
            this.btnRemoveDoctor.UseVisualStyleBackColor = true;
            this.btnRemoveDoctor.Click += new System.EventHandler(this.btnRemoveDoctor_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(956, 211);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 41);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(850, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 1105);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemoveDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.lvDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvDoctor;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnRemoveDoctor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listView1;
    }
}

