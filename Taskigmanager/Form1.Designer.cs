namespace Taskigmanager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tasks = new ListBox();
            SuspendLayout();
            // 
            // Tasks
            // 
            Tasks.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Tasks.FormattingEnabled = true;
            Tasks.ItemHeight = 30;
            Tasks.Location = new Point(496, 12);
            Tasks.Name = "Tasks";
            Tasks.Size = new Size(292, 424);
            Tasks.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tasks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Tasks;
    }
}