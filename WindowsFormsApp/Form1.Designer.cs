namespace WindowsFormsApp
{
    partial class NoteTaker
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.perviousNotes = new System.Windows.Forms.DataGridView();
            this.LoadButtom = new System.Windows.Forms.Button();
            this.DeleteButtom = new System.Windows.Forms.Button();
            this.SaveButtom = new System.Windows.Forms.Button();
            this.NewNoteButtom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perviousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(388, 25);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(400, 20);
            this.titleBox.TabIndex = 0;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(388, 74);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(400, 364);
            this.noteBox.TabIndex = 1;
            this.noteBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // perviousNotes
            // 
            this.perviousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.perviousNotes.BackgroundColor = System.Drawing.Color.White;
            this.perviousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perviousNotes.Location = new System.Drawing.Point(5, 9);
            this.perviousNotes.Name = "perviousNotes";
            this.perviousNotes.Size = new System.Drawing.Size(374, 331);
            this.perviousNotes.TabIndex = 4;
            this.perviousNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.perviousNotes_CellContentClick);
            this.perviousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.perviousNotes_CellDoubleClick);
            // 
            // LoadButtom
            // 
            this.LoadButtom.BackColor = System.Drawing.Color.White;
            this.LoadButtom.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButtom.Location = new System.Drawing.Point(5, 346);
            this.LoadButtom.Name = "LoadButtom";
            this.LoadButtom.Size = new System.Drawing.Size(179, 49);
            this.LoadButtom.TabIndex = 5;
            this.LoadButtom.Text = "Load";
            this.LoadButtom.UseVisualStyleBackColor = false;
            this.LoadButtom.Click += new System.EventHandler(this.LoadButtom_Click);
            // 
            // DeleteButtom
            // 
            this.DeleteButtom.BackColor = System.Drawing.Color.White;
            this.DeleteButtom.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButtom.Location = new System.Drawing.Point(200, 346);
            this.DeleteButtom.Name = "DeleteButtom";
            this.DeleteButtom.Size = new System.Drawing.Size(179, 49);
            this.DeleteButtom.TabIndex = 6;
            this.DeleteButtom.Text = "Delete";
            this.DeleteButtom.UseVisualStyleBackColor = false;
            this.DeleteButtom.Click += new System.EventHandler(this.DeleteButtom_Click);
            // 
            // SaveButtom
            // 
            this.SaveButtom.BackColor = System.Drawing.Color.White;
            this.SaveButtom.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtom.Location = new System.Drawing.Point(203, 401);
            this.SaveButtom.Name = "SaveButtom";
            this.SaveButtom.Size = new System.Drawing.Size(179, 45);
            this.SaveButtom.TabIndex = 7;
            this.SaveButtom.Text = "Save";
            this.SaveButtom.UseVisualStyleBackColor = false;
            this.SaveButtom.Click += new System.EventHandler(this.SaveButtom_Click);
            // 
            // NewNoteButtom
            // 
            this.NewNoteButtom.BackColor = System.Drawing.Color.White;
            this.NewNoteButtom.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNoteButtom.Location = new System.Drawing.Point(5, 401);
            this.NewNoteButtom.Name = "NewNoteButtom";
            this.NewNoteButtom.Size = new System.Drawing.Size(179, 45);
            this.NewNoteButtom.TabIndex = 8;
            this.NewNoteButtom.Text = "New Note";
            this.NewNoteButtom.UseVisualStyleBackColor = false;
            this.NewNoteButtom.Click += new System.EventHandler(this.NewNoteButtom_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewNoteButtom);
            this.Controls.Add(this.SaveButtom);
            this.Controls.Add(this.DeleteButtom);
            this.Controls.Add(this.LoadButtom);
            this.Controls.Add(this.perviousNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteTaker";
            this.Text = "NoteTaker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perviousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView perviousNotes;
        private System.Windows.Forms.Button LoadButtom;
        private System.Windows.Forms.Button DeleteButtom;
        private System.Windows.Forms.Button SaveButtom;
        private System.Windows.Forms.Button NewNoteButtom;
    }
}

