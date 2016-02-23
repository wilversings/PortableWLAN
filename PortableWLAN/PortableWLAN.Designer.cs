namespace PortableWLAN {
    partial class PortableWLAN {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortableWLAN));
            this.SSIDTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.toggleBroadcastButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SSIDTextBox
            // 
            resources.ApplyResources(this.SSIDTextBox, "SSIDTextBox");
            this.SSIDTextBox.Name = "SSIDTextBox";
            this.SSIDTextBox.TextChanged += new System.EventHandler(this.SSIDTextBox_TextChanged);
            // 
            // KeyTextBox
            // 
            resources.ApplyResources(this.KeyTextBox, "KeyTextBox");
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.UseSystemPasswordChar = true;
            // 
            // toggleBroadcastButton
            // 
            resources.ApplyResources(this.toggleBroadcastButton, "toggleBroadcastButton");
            this.toggleBroadcastButton.Name = "toggleBroadcastButton";
            this.toggleBroadcastButton.UseVisualStyleBackColor = true;
            this.toggleBroadcastButton.Click += new System.EventHandler(this.toggleBroadcastButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // showKeyCheckBox
            // 
            resources.ApplyResources(this.showKeyCheckBox, "showKeyCheckBox");
            this.showKeyCheckBox.Name = "showKeyCheckBox";
            this.showKeyCheckBox.UseVisualStyleBackColor = true;
            this.showKeyCheckBox.CheckedChanged += new System.EventHandler(this.showKeyCheckBox_CheckedChanged);
            // 
            // PortableWLAN
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showKeyCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleBroadcastButton);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.SSIDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PortableWLAN";
            this.Load += new System.EventHandler(this.PortableWLAN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SSIDTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button toggleBroadcastButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showKeyCheckBox;
    }
}

