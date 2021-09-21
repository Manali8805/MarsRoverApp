namespace MarsRoverApp
{
    partial class frmRover
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtMaxPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoverPosition = new System.Windows.Forms.TextBox();
            this.txtMovingOrder = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max. Position";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtMaxPosition
            // 
            this.txtMaxPosition.Location = new System.Drawing.Point(129, 31);
            this.txtMaxPosition.Name = "txtMaxPosition";
            this.txtMaxPosition.Size = new System.Drawing.Size(100, 20);
            this.txtMaxPosition.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtMaxPosition, "Enter max. limit for rover position. \r\nData should be in \'X Y\' format. eg. 1 5 ");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rover Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Moving Order";
            // 
            // txtRoverPosition
            // 
            this.txtRoverPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRoverPosition.Location = new System.Drawing.Point(129, 70);
            this.txtRoverPosition.Name = "txtRoverPosition";
            this.txtRoverPosition.Size = new System.Drawing.Size(100, 20);
            this.txtRoverPosition.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtRoverPosition, "Enter current position of Rover.\r\nData should be in format \'X Y Dir\'. eg. 1 2 N\r\n" +
        "");
            // 
            // txtMovingOrder
            // 
            this.txtMovingOrder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMovingOrder.Location = new System.Drawing.Point(129, 106);
            this.txtMovingOrder.Name = "txtMovingOrder";
            this.txtMovingOrder.Size = new System.Drawing.Size(205, 20);
            this.txtMovingOrder.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtMovingOrder, "Enter moving series for the rover. \r\nData should be continoues series if L, M & R" +
        ". \r\nNo other character will be processed including space.\r\n");
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(129, 156);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(87, 23);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Start Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Controls.Add(this.label5);
            this.grpResult.Location = new System.Drawing.Point(29, 197);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(230, 82);
            this.grpResult.TabIndex = 11;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            this.grpResult.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(97, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Position";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmRover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 362);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtMovingOrder);
            this.Controls.Add(this.txtRoverPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxPosition);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Name = "frmRover";
            this.Text = "Form1";
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtMaxPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoverPosition;
        private System.Windows.Forms.TextBox txtMovingOrder;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

