﻿namespace ExpenseAPPBig
{
    partial class CategoryModifyForm
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
            this.deleteCategoryBtn = new System.Windows.Forms.Button();
            this.updateCategoryBtn = new System.Windows.Forms.Button();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateCategoryPanel = new System.Windows.Forms.Panel();
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.newBudgetCB = new System.Windows.Forms.NumericUpDown();
            this.updateWarningLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.existingCategoryCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updatedCategoryTB = new System.Windows.Forms.TextBox();
            this.updateCancel = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteCategoryPanel = new System.Windows.Forms.Panel();
            this.deleteWarningLabel = new System.Windows.Forms.Label();
            this.deleteCategoryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteCancel = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addCategoryPanel = new System.Windows.Forms.Panel();
            this.catBudgetTB = new System.Windows.Forms.NumericUpDown();
            this.addWarningLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addCategoryLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addCancelBtn = new System.Windows.Forms.Button();
            this.newCategoryTB = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.updateCategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newBudgetCB)).BeginInit();
            this.deleteCategoryPanel.SuspendLayout();
            this.addCategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catBudgetTB)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteCategoryBtn
            // 
            this.deleteCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.deleteCategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCategoryBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.deleteCategoryBtn.Location = new System.Drawing.Point(337, 15);
            this.deleteCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCategoryBtn.Name = "deleteCategoryBtn";
            this.deleteCategoryBtn.Size = new System.Drawing.Size(146, 32);
            this.deleteCategoryBtn.TabIndex = 3;
            this.deleteCategoryBtn.Text = "Delete Category";
            this.deleteCategoryBtn.UseVisualStyleBackColor = false;
            this.deleteCategoryBtn.Click += new System.EventHandler(this.DeleteCategoryBtnClick);
            // 
            // updateCategoryBtn
            // 
            this.updateCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.updateCategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCategoryBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.updateCategoryBtn.Location = new System.Drawing.Point(168, 15);
            this.updateCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateCategoryBtn.Name = "updateCategoryBtn";
            this.updateCategoryBtn.Size = new System.Drawing.Size(146, 32);
            this.updateCategoryBtn.TabIndex = 4;
            this.updateCategoryBtn.Text = "Update Category";
            this.updateCategoryBtn.UseVisualStyleBackColor = false;
            this.updateCategoryBtn.Click += new System.EventHandler(this.UpdateCategoryBtClick);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.addCategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategoryBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.addCategoryBtn.Location = new System.Drawing.Point(8, 15);
            this.addCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(146, 32);
            this.addCategoryBtn.TabIndex = 6;
            this.addCategoryBtn.Text = "Add Category";
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.updateCategoryBtn);
            this.panel1.Controls.Add(this.deleteCategoryBtn);
            this.panel1.Controls.Add(this.addCategoryBtn);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 58);
            this.panel1.TabIndex = 7;
            // 
            // updateCategoryPanel
            // 
            this.updateCategoryPanel.Controls.Add(this.MonthCB);
            this.updateCategoryPanel.Controls.Add(this.newBudgetCB);
            this.updateCategoryPanel.Controls.Add(this.updateWarningLabel);
            this.updateCategoryPanel.Controls.Add(this.label8);
            this.updateCategoryPanel.Controls.Add(this.existingCategoryCB);
            this.updateCategoryPanel.Controls.Add(this.label9);
            this.updateCategoryPanel.Controls.Add(this.label3);
            this.updateCategoryPanel.Controls.Add(this.label4);
            this.updateCategoryPanel.Controls.Add(this.label1);
            this.updateCategoryPanel.Controls.Add(this.updatedCategoryTB);
            this.updateCategoryPanel.Controls.Add(this.updateCancel);
            this.updateCategoryPanel.Controls.Add(this.updateBtn);
            this.updateCategoryPanel.Location = new System.Drawing.Point(91, 68);
            this.updateCategoryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.updateCategoryPanel.Name = "updateCategoryPanel";
            this.updateCategoryPanel.Size = new System.Drawing.Size(368, 280);
            this.updateCategoryPanel.TabIndex = 8;
            this.updateCategoryPanel.Visible = false;
            // 
            // MonthCB
            // 
            this.MonthCB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Location = new System.Drawing.Point(159, 147);
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(185, 26);
            this.MonthCB.TabIndex = 5;
            // 
            // newBudgetCB
            // 
            this.newBudgetCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBudgetCB.Location = new System.Drawing.Point(159, 188);
            this.newBudgetCB.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.newBudgetCB.Name = "newBudgetCB";
            this.newBudgetCB.Size = new System.Drawing.Size(185, 27);
            this.newBudgetCB.TabIndex = 4;
            // 
            // updateWarningLabel
            // 
            this.updateWarningLabel.AutoSize = true;
            this.updateWarningLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.updateWarningLabel.Location = new System.Drawing.Point(147, 277);
            this.updateWarningLabel.Name = "updateWarningLabel";
            this.updateWarningLabel.Size = new System.Drawing.Size(0, 13);
            this.updateWarningLabel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(81, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Budget";
            // 
            // existingCategoryCB
            // 
            this.existingCategoryCB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingCategoryCB.FormattingEnabled = true;
            this.existingCategoryCB.Location = new System.Drawing.Point(159, 55);
            this.existingCategoryCB.Name = "existingCategoryCB";
            this.existingCategoryCB.Size = new System.Drawing.Size(185, 26);
            this.existingCategoryCB.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(89, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "UPDATE EXISTING CATEGORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing Category";
            // 
            // updatedCategoryTB
            // 
            this.updatedCategoryTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedCategoryTB.Location = new System.Drawing.Point(159, 98);
            this.updatedCategoryTB.Margin = new System.Windows.Forms.Padding(2);
            this.updatedCategoryTB.Name = "updatedCategoryTB";
            this.updatedCategoryTB.Size = new System.Drawing.Size(185, 27);
            this.updatedCategoryTB.TabIndex = 1;
            // 
            // updateCancel
            // 
            this.updateCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.updateCancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCancel.ForeColor = System.Drawing.Color.White;
            this.updateCancel.Location = new System.Drawing.Point(107, 240);
            this.updateCancel.Margin = new System.Windows.Forms.Padding(2);
            this.updateCancel.Name = "updateCancel";
            this.updateCancel.Size = new System.Drawing.Size(67, 32);
            this.updateCancel.TabIndex = 2;
            this.updateCancel.Text = "Cancel";
            this.updateCancel.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.updateBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(213, 240);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(68, 32);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtClick);
            // 
            // deleteCategoryPanel
            // 
            this.deleteCategoryPanel.Controls.Add(this.deleteWarningLabel);
            this.deleteCategoryPanel.Controls.Add(this.deleteCategoryCB);
            this.deleteCategoryPanel.Controls.Add(this.label2);
            this.deleteCategoryPanel.Controls.Add(this.label5);
            this.deleteCategoryPanel.Controls.Add(this.deleteCancel);
            this.deleteCategoryPanel.Controls.Add(this.deleteBtn);
            this.deleteCategoryPanel.Location = new System.Drawing.Point(70, 73);
            this.deleteCategoryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCategoryPanel.Name = "deleteCategoryPanel";
            this.deleteCategoryPanel.Size = new System.Drawing.Size(413, 168);
            this.deleteCategoryPanel.TabIndex = 9;
            this.deleteCategoryPanel.Visible = false;
            // 
            // deleteWarningLabel
            // 
            this.deleteWarningLabel.AutoSize = true;
            this.deleteWarningLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteWarningLabel.Location = new System.Drawing.Point(126, 144);
            this.deleteWarningLabel.Name = "deleteWarningLabel";
            this.deleteWarningLabel.Size = new System.Drawing.Size(0, 13);
            this.deleteWarningLabel.TabIndex = 3;
            // 
            // deleteCategoryCB
            // 
            this.deleteCategoryCB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryCB.FormattingEnabled = true;
            this.deleteCategoryCB.Location = new System.Drawing.Point(164, 54);
            this.deleteCategoryCB.Name = "deleteCategoryCB";
            this.deleteCategoryCB.Size = new System.Drawing.Size(186, 26);
            this.deleteCategoryCB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(104, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "DELETE CATEGORY";
            // 
            // deleteCancel
            // 
            this.deleteCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.deleteCancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCancel.ForeColor = System.Drawing.Color.White;
            this.deleteCancel.Location = new System.Drawing.Point(76, 98);
            this.deleteCancel.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCancel.Name = "deleteCancel";
            this.deleteCancel.Size = new System.Drawing.Size(67, 32);
            this.deleteCancel.TabIndex = 2;
            this.deleteCancel.Text = "Cancel";
            this.deleteCancel.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(221, 98);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(61, 32);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtClick);
            // 
            // addCategoryPanel
            // 
            this.addCategoryPanel.Controls.Add(this.catBudgetTB);
            this.addCategoryPanel.Controls.Add(this.addWarningLabel);
            this.addCategoryPanel.Controls.Add(this.label7);
            this.addCategoryPanel.Controls.Add(this.addCategoryLabel);
            this.addCategoryPanel.Controls.Add(this.label6);
            this.addCategoryPanel.Controls.Add(this.addCancelBtn);
            this.addCategoryPanel.Controls.Add(this.newCategoryTB);
            this.addCategoryPanel.Controls.Add(this.okBtn);
            this.addCategoryPanel.Location = new System.Drawing.Point(48, 68);
            this.addCategoryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addCategoryPanel.Name = "addCategoryPanel";
            this.addCategoryPanel.Size = new System.Drawing.Size(420, 236);
            this.addCategoryPanel.TabIndex = 10;
            this.addCategoryPanel.Visible = false;
            // 
            // catBudgetTB
            // 
            this.catBudgetTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBudgetTB.Location = new System.Drawing.Point(154, 118);
            this.catBudgetTB.Name = "catBudgetTB";
            this.catBudgetTB.Size = new System.Drawing.Size(185, 27);
            this.catBudgetTB.TabIndex = 4;
            // 
            // addWarningLabel
            // 
            this.addWarningLabel.AutoSize = true;
            this.addWarningLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.addWarningLabel.Location = new System.Drawing.Point(131, 209);
            this.addWarningLabel.Name = "addWarningLabel";
            this.addWarningLabel.Size = new System.Drawing.Size(0, 13);
            this.addWarningLabel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(79, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Budget";
            // 
            // addCategoryLabel
            // 
            this.addCategoryLabel.AutoSize = true;
            this.addCategoryLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryLabel.ForeColor = System.Drawing.Color.White;
            this.addCategoryLabel.Location = new System.Drawing.Point(16, 78);
            this.addCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addCategoryLabel.Name = "addCategoryLabel";
            this.addCategoryLabel.Size = new System.Drawing.Size(134, 18);
            this.addCategoryLabel.TabIndex = 0;
            this.addCategoryLabel.Text = "Category Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(103, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "ADD NEW CATEGORY";
            // 
            // addCancelBtn
            // 
            this.addCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.addCancelBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCancelBtn.Location = new System.Drawing.Point(83, 162);
            this.addCancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCancelBtn.Name = "addCancelBtn";
            this.addCancelBtn.Size = new System.Drawing.Size(67, 32);
            this.addCancelBtn.TabIndex = 2;
            this.addCancelBtn.Text = "Cancel";
            this.addCancelBtn.UseVisualStyleBackColor = false;
            // 
            // newCategoryTB
            // 
            this.newCategoryTB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCategoryTB.Location = new System.Drawing.Point(154, 69);
            this.newCategoryTB.Margin = new System.Windows.Forms.Padding(2);
            this.newCategoryTB.Name = "newCategoryTB";
            this.newCategoryTB.Size = new System.Drawing.Size(186, 27);
            this.newCategoryTB.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.okBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.Black;
            this.okBtn.Location = new System.Drawing.Point(224, 162);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(61, 32);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Add";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.AddBtClick);
            // 
            // CategoryModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(533, 64);
            this.Controls.Add(this.deleteCategoryPanel);
            this.Controls.Add(this.addCategoryPanel);
            this.Controls.Add(this.updateCategoryPanel);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryModifyForm";
            this.Text = "CategoryModifyForm";
            this.panel1.ResumeLayout(false);
            this.updateCategoryPanel.ResumeLayout(false);
            this.updateCategoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newBudgetCB)).EndInit();
            this.deleteCategoryPanel.ResumeLayout(false);
            this.deleteCategoryPanel.PerformLayout();
            this.addCategoryPanel.ResumeLayout(false);
            this.addCategoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catBudgetTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteCategoryBtn;
        private System.Windows.Forms.Button updateCategoryBtn;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel updateCategoryPanel;
        private System.Windows.Forms.ComboBox MonthCB;
        private System.Windows.Forms.NumericUpDown newBudgetCB;
        private System.Windows.Forms.Label updateWarningLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox existingCategoryCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox updatedCategoryTB;
        private System.Windows.Forms.Button updateCancel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel deleteCategoryPanel;
        private System.Windows.Forms.Label deleteWarningLabel;
        private System.Windows.Forms.ComboBox deleteCategoryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteCancel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel addCategoryPanel;
        private System.Windows.Forms.NumericUpDown catBudgetTB;
        private System.Windows.Forms.Label addWarningLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label addCategoryLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addCancelBtn;
        private System.Windows.Forms.TextBox newCategoryTB;
        private System.Windows.Forms.Button okBtn;
    }
}