namespace PoliceDispatcherClient
{
    partial class DispatcherForm
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.btnLogIncident = new System.Windows.Forms.Button();
            this.btnLocateOfficer = new System.Windows.Forms.Button();
            this.tbOfficer = new System.Windows.Forms.TextBox();
            this.lblOfficer = new System.Windows.Forms.Label();
            this.btnCall = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(15, 45);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 0;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(15, 105);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(147, 20);
            this.tbStreet.TabIndex = 1;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(12, 89);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(76, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street Address";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(15, 167);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(147, 20);
            this.tbCity.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(15, 148);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(15, 225);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 21);
            this.cbState.TabIndex = 5;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(15, 206);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // btnLogIncident
            // 
            this.btnLogIncident.Location = new System.Drawing.Point(285, 45);
            this.btnLogIncident.Name = "btnLogIncident";
            this.btnLogIncident.Size = new System.Drawing.Size(147, 23);
            this.btnLogIncident.TabIndex = 7;
            this.btnLogIncident.Text = "Log Incident";
            this.btnLogIncident.UseVisualStyleBackColor = true;
            // 
            // btnLocateOfficer
            // 
            this.btnLocateOfficer.Location = new System.Drawing.Point(285, 105);
            this.btnLocateOfficer.Name = "btnLocateOfficer";
            this.btnLocateOfficer.Size = new System.Drawing.Size(147, 23);
            this.btnLocateOfficer.TabIndex = 8;
            this.btnLocateOfficer.Text = "Locate Nearest Officer";
            this.btnLocateOfficer.UseVisualStyleBackColor = true;
            // 
            // tbOfficer
            // 
            this.tbOfficer.Location = new System.Drawing.Point(285, 167);
            this.tbOfficer.Name = "tbOfficer";
            this.tbOfficer.Size = new System.Drawing.Size(147, 20);
            this.tbOfficer.TabIndex = 9;
            // 
            // lblOfficer
            // 
            this.lblOfficer.AutoSize = true;
            this.lblOfficer.Location = new System.Drawing.Point(282, 148);
            this.lblOfficer.Name = "lblOfficer";
            this.lblOfficer.Size = new System.Drawing.Size(41, 13);
            this.lblOfficer.TabIndex = 10;
            this.lblOfficer.Text = "Officer:";
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(285, 194);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(147, 23);
            this.btnCall.TabIndex = 11;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 29);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(75, 13);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Incident Type:";
            // 
            // DispatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 262);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.lblOfficer);
            this.Controls.Add(this.tbOfficer);
            this.Controls.Add(this.btnLocateOfficer);
            this.Controls.Add(this.btnLogIncident);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.cbType);
            this.Name = "DispatcherForm";
            this.Text = "Police Dispatcher Client - E237 Cameron Logan";
            this.Load += new System.EventHandler(this.DispatcherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnLogIncident;
        private System.Windows.Forms.Button btnLocateOfficer;
        private System.Windows.Forms.TextBox tbOfficer;
        private System.Windows.Forms.Label lblOfficer;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Label lblType;
    }
}

