namespace BreathFirstSearch
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
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStartNode = new System.Windows.Forms.Label();
            this.lblEndNode = new System.Windows.Forms.Label();
            this.cbx2 = new System.Windows.Forms.ComboBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbx1
            // 
            this.cbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(111, 96);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(244, 28);
            this.cbx1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(36, 34);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(167, 44);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load JSON File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(209, 34);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(502, 44);
            this.tb1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(282, 351);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search Path";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStartNode
            // 
            this.lblStartNode.AutoSize = true;
            this.lblStartNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartNode.Location = new System.Drawing.Point(33, 102);
            this.lblStartNode.Name = "lblStartNode";
            this.lblStartNode.Size = new System.Drawing.Size(72, 16);
            this.lblStartNode.TabIndex = 4;
            this.lblStartNode.Text = "Start Node";
            // 
            // lblEndNode
            // 
            this.lblEndNode.AutoSize = true;
            this.lblEndNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndNode.Location = new System.Drawing.Point(392, 102);
            this.lblEndNode.Name = "lblEndNode";
            this.lblEndNode.Size = new System.Drawing.Size(69, 16);
            this.lblEndNode.TabIndex = 5;
            this.lblEndNode.Text = "End Node";
            // 
            // cbx2
            // 
            this.cbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx2.FormattingEnabled = true;
            this.cbx2.Location = new System.Drawing.Point(467, 96);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(244, 28);
            this.cbx2.TabIndex = 6;
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(36, 144);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(675, 198);
            this.tbPath.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 407);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.lblEndNode);
            this.Controls.Add(this.lblStartNode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbx1);
            this.Name = "Form1";
            this.Text = "Breath First Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStartNode;
        private System.Windows.Forms.Label lblEndNode;
        private System.Windows.Forms.ComboBox cbx2;
        private System.Windows.Forms.TextBox tbPath;
    }
}

