
namespace Pluto_PVI_trial_01
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "PC_cmd.autocentkV",
            "Start autocenter for currently set kV",
            "Boolean",
            "Write"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "PC_cmd.autocentALL",
            "Start autocenter for all kV",
            "Boolean",
            "Write"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "PC_cmd.conditioning",
            "Start conditioning",
            "Boolean",
            "Write"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("PC_cmd.filamentadjust");
            this.btnConnectPLC = new System.Windows.Forms.Button();
            this.btnConnectVariable = new System.Windows.Forms.Button();
            this.lblVarValue = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpVariables = new System.Windows.Forms.GroupBox();
            this.panelVariableWrite = new System.Windows.Forms.Panel();
            this.tbVarValue = new System.Windows.Forms.TextBox();
            this.btnVariableWrite = new System.Windows.Forms.Button();
            this.panelVariableRead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVarNameRead = new System.Windows.Forms.TextBox();
            this.btnDisconnectVariable = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpVariables.SuspendLayout();
            this.panelVariableWrite.SuspendLayout();
            this.panelVariableRead.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.Location = new System.Drawing.Point(28, 11);
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.Size = new System.Drawing.Size(114, 23);
            this.btnConnectPLC.TabIndex = 0;
            this.btnConnectPLC.Text = "Connect PLC";
            this.btnConnectPLC.UseVisualStyleBackColor = true;
            this.btnConnectPLC.Click += new System.EventHandler(this.btnConnectPLC_Click);
            // 
            // btnConnectVariable
            // 
            this.btnConnectVariable.Location = new System.Drawing.Point(193, 9);
            this.btnConnectVariable.Name = "btnConnectVariable";
            this.btnConnectVariable.Size = new System.Drawing.Size(114, 23);
            this.btnConnectVariable.TabIndex = 1;
            this.btnConnectVariable.Text = "Connect variable";
            this.btnConnectVariable.UseVisualStyleBackColor = true;
            this.btnConnectVariable.Click += new System.EventHandler(this.btnConnectVariable_Click);
            // 
            // lblVarValue
            // 
            this.lblVarValue.AutoSize = true;
            this.lblVarValue.Location = new System.Drawing.Point(10, 12);
            this.lblVarValue.Name = "lblVarValue";
            this.lblVarValue.Size = new System.Drawing.Size(37, 13);
            this.lblVarValue.TabIndex = 2;
            this.lblVarValue.Text = "Value:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1237, 625);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbLog);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer2.Size = new System.Drawing.Size(1102, 625);
            this.splitContainer2.SplitterDistance = 240;
            this.splitContainer2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(537, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 238);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpVariables);
            this.panel1.Controls.Add(this.btnConnectPLC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 238);
            this.panel1.TabIndex = 4;
            // 
            // grpVariables
            // 
            this.grpVariables.Controls.Add(this.panelVariableWrite);
            this.grpVariables.Controls.Add(this.panelVariableRead);
            this.grpVariables.Controls.Add(this.btnDisconnectVariable);
            this.grpVariables.Enabled = false;
            this.grpVariables.Location = new System.Drawing.Point(14, 55);
            this.grpVariables.Name = "grpVariables";
            this.grpVariables.Size = new System.Drawing.Size(505, 145);
            this.grpVariables.TabIndex = 9;
            this.grpVariables.TabStop = false;
            this.grpVariables.Text = "Variables";
            // 
            // panelVariableWrite
            // 
            this.panelVariableWrite.Controls.Add(this.tbVarValue);
            this.panelVariableWrite.Controls.Add(this.btnVariableWrite);
            this.panelVariableWrite.Controls.Add(this.lblVarValue);
            this.panelVariableWrite.Enabled = false;
            this.panelVariableWrite.Location = new System.Drawing.Point(14, 97);
            this.panelVariableWrite.Name = "panelVariableWrite";
            this.panelVariableWrite.Size = new System.Drawing.Size(318, 38);
            this.panelVariableWrite.TabIndex = 8;
            // 
            // tbVarValue
            // 
            this.tbVarValue.Location = new System.Drawing.Point(88, 9);
            this.tbVarValue.Name = "tbVarValue";
            this.tbVarValue.Size = new System.Drawing.Size(76, 20);
            this.tbVarValue.TabIndex = 1;
            // 
            // btnVariableWrite
            // 
            this.btnVariableWrite.Location = new System.Drawing.Point(193, 7);
            this.btnVariableWrite.Name = "btnVariableWrite";
            this.btnVariableWrite.Size = new System.Drawing.Size(114, 23);
            this.btnVariableWrite.TabIndex = 0;
            this.btnVariableWrite.Text = "Write";
            this.btnVariableWrite.UseVisualStyleBackColor = true;
            this.btnVariableWrite.Click += new System.EventHandler(this.btnVariableWrite_Click);
            this.btnVariableWrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVarValue_KeyPress);
            // 
            // panelVariableRead
            // 
            this.panelVariableRead.Controls.Add(this.label1);
            this.panelVariableRead.Controls.Add(this.btnConnectVariable);
            this.panelVariableRead.Controls.Add(this.tbVarNameRead);
            this.panelVariableRead.Enabled = false;
            this.panelVariableRead.Location = new System.Drawing.Point(14, 26);
            this.panelVariableRead.Margin = new System.Windows.Forms.Padding(2);
            this.panelVariableRead.Name = "panelVariableRead";
            this.panelVariableRead.Size = new System.Drawing.Size(318, 41);
            this.panelVariableRead.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Variable name:";
            // 
            // tbVarNameRead
            // 
            this.tbVarNameRead.Location = new System.Drawing.Point(88, 10);
            this.tbVarNameRead.Margin = new System.Windows.Forms.Padding(2);
            this.tbVarNameRead.Name = "tbVarNameRead";
            this.tbVarNameRead.Size = new System.Drawing.Size(76, 20);
            this.tbVarNameRead.TabIndex = 5;
            this.tbVarNameRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVarNameRead_KeyPress);
            // 
            // btnDisconnectVariable
            // 
            this.btnDisconnectVariable.Location = new System.Drawing.Point(358, 26);
            this.btnDisconnectVariable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnectVariable.Name = "btnDisconnectVariable";
            this.btnDisconnectVariable.Size = new System.Drawing.Size(114, 109);
            this.btnDisconnectVariable.TabIndex = 6;
            this.btnDisconnectVariable.Text = "Disconnect variable";
            this.btnDisconnectVariable.UseVisualStyleBackColor = true;
            this.btnDisconnectVariable.Click += new System.EventHandler(this.btnDisconnectVariable_Click);
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(10, 10);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(1080, 359);
            this.tbLog.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1237, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 625);
            this.panel2.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Command,
            this.Description,
            this.Value_Type,
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 238);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Command
            // 
            this.Command.Text = "Command";
            this.Command.Width = 200;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 200;
            // 
            // Value_Type
            // 
            this.Value_Type.Text = "Value Type";
            this.Value_Type.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Pluto - PVI demo";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpVariables.ResumeLayout(false);
            this.panelVariableWrite.ResumeLayout(false);
            this.panelVariableWrite.PerformLayout();
            this.panelVariableRead.ResumeLayout(false);
            this.panelVariableRead.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectPLC;
        private System.Windows.Forms.Button btnConnectVariable;
        private System.Windows.Forms.Label lblVarValue;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVarNameRead;
        private System.Windows.Forms.Panel panelVariableRead;
        private System.Windows.Forms.Button btnDisconnectVariable;
        private System.Windows.Forms.Panel panelVariableWrite;
        private System.Windows.Forms.TextBox tbVarValue;
        private System.Windows.Forms.Button btnVariableWrite;
        private System.Windows.Forms.GroupBox grpVariables;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Command;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Value_Type;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

