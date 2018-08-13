namespace tut3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lstInspections = new System.Windows.Forms.ListBox();
            this.btRequestInspection = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalNumberOfRequest = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(532, 25);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(89, 18);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "lblHeader";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lstInspections
            // 
            this.lstInspections.FormattingEnabled = true;
            this.lstInspections.ItemHeight = 18;
            this.lstInspections.Location = new System.Drawing.Point(438, 125);
            this.lstInspections.Margin = new System.Windows.Forms.Padding(4);
            this.lstInspections.Name = "lstInspections";
            this.lstInspections.Size = new System.Drawing.Size(487, 202);
            this.lstInspections.TabIndex = 1;
            this.lstInspections.SelectedIndexChanged += new System.EventHandler(this.lbInspections_SelectedIndexChanged);
            // 
            // btRequestInspection
            // 
            this.btRequestInspection.Location = new System.Drawing.Point(63, 267);
            this.btRequestInspection.Margin = new System.Windows.Forms.Padding(4);
            this.btRequestInspection.Name = "btRequestInspection";
            this.btRequestInspection.Size = new System.Drawing.Size(248, 39);
            this.btRequestInspection.TabIndex = 3;
            this.btRequestInspection.Text = "Request Inspection";
            this.btRequestInspection.UseVisualStyleBackColor = true;
            this.btRequestInspection.Click += new System.EventHandler(this.btRequestInspection_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(115, 456);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(89, 18);
            this.lblDetails.TabIndex = 4;
            this.lblDetails.Text = "lblDetail";
            this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(514, 504);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(107, 18);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Total Price";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // lblTotalNumberOfRequest
            // 
            this.lblTotalNumberOfRequest.AutoSize = true;
            this.lblTotalNumberOfRequest.Location = new System.Drawing.Point(868, 505);
            this.lblTotalNumberOfRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNumberOfRequest.Name = "lblTotalNumberOfRequest";
            this.lblTotalNumberOfRequest.Size = new System.Drawing.Size(215, 18);
            this.lblTotalNumberOfRequest.TabIndex = 6;
            this.lblTotalNumberOfRequest.Text = "Total Number Of Request";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(188, 137);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(71, 18);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "SELECT ";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(944, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total NUMBER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTotalNumberOfRequest);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btRequestInspection);
            this.Controls.Add(this.lstInspections);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox lstInspections;
        private System.Windows.Forms.Button btRequestInspection;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalNumberOfRequest;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

