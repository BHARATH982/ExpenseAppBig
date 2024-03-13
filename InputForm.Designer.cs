namespace ExpenseAPPBig
{
    partial class InputForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(86, 215);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 31);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.Magenta;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 15);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(244, 30);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.TabStop = false;
            // 
            // categoryCB
            // 
            this.categoryCB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(12, 87);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(244, 32);
            this.categoryCB.TabIndex = 8;
            this.categoryCB.TabStop = false;
            this.categoryCB.Text = "Category";
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            this.categoryCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categoryCB_KeyPress);
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.amountTB.Location = new System.Drawing.Point(12, 125);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(244, 30);
            this.amountTB.TabIndex = 5;
            this.amountTB.TabStop = false;
            this.amountTB.Text = "Amount";
            this.amountTB.Click += new System.EventHandler(this.OnAmountTBClick);
            // 
            // descriptionTB
            // 
            this.descriptionTB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.descriptionTB.Location = new System.Drawing.Point(12, 161);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(244, 38);
            this.descriptionTB.TabIndex = 6;
            this.descriptionTB.TabStop = false;
            this.descriptionTB.Text = "Note";
            this.descriptionTB.Click += new System.EventHandler(this.OnDescriptionTBClick);
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.NameTB.Location = new System.Drawing.Point(12, 51);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(244, 30);
            this.NameTB.TabIndex = 7;
            this.NameTB.TabStop = false;
            this.NameTB.Text = "Name";
            this.NameTB.Click += new System.EventHandler(this.OnNameTBClick);
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.ForeColor = System.Drawing.Color.Black;
            this.amountNumericUpDown.Location = new System.Drawing.Point(12, 125);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(244, 30);
            this.amountNumericUpDown.TabIndex = 9;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(48, 249);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 24);
            this.errorLabel.TabIndex = 13;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(270, 283);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.amountNumericUpDown);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Label errorLabel;
    }
}