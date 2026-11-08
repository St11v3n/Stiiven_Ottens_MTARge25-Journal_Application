namespace Journal_Application
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
            PagePanel = new Panel();
            PlannerPageButton = new Button();
            JournalPageButton = new Button();
            JournalMainPanel = new Panel();
            JournalEntryTextBox = new TextBox();
            JournalEntryPanel = new Panel();
            PagePanel.SuspendLayout();
            JournalMainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PagePanel
            // 
            PagePanel.Controls.Add(PlannerPageButton);
            PagePanel.Controls.Add(JournalPageButton);
            PagePanel.Dock = DockStyle.Top;
            PagePanel.Location = new Point(0, 0);
            PagePanel.Name = "PagePanel";
            PagePanel.Size = new Size(966, 28);
            PagePanel.TabIndex = 0;
            // 
            // PlannerPageButton
            // 
            PlannerPageButton.Location = new Point(460, 0);
            PlannerPageButton.Name = "PlannerPageButton";
            PlannerPageButton.Size = new Size(75, 28);
            PlannerPageButton.TabIndex = 1;
            PlannerPageButton.Text = "Planner";
            PlannerPageButton.UseVisualStyleBackColor = true;
            PlannerPageButton.Visible = false;
            PlannerPageButton.Click += button2_Click;
            // 
            // JournalPageButton
            // 
            JournalPageButton.Location = new Point(318, 0);
            JournalPageButton.Name = "JournalPageButton";
            JournalPageButton.Size = new Size(84, 28);
            JournalPageButton.TabIndex = 0;
            JournalPageButton.Text = "Journal";
            JournalPageButton.UseVisualStyleBackColor = true;
            // 
            // JournalMainPanel
            // 
            JournalMainPanel.Controls.Add(JournalEntryTextBox);
            JournalMainPanel.Dock = DockStyle.Fill;
            JournalMainPanel.Location = new Point(0, 0);
            JournalMainPanel.Name = "JournalMainPanel";
            JournalMainPanel.Size = new Size(966, 534);
            JournalMainPanel.TabIndex = 1;
            // 
            // JournalEntryTextBox
            // 
            JournalEntryTextBox.Dock = DockStyle.Fill;
            JournalEntryTextBox.Location = new Point(0, 0);
            JournalEntryTextBox.Multiline = true;
            JournalEntryTextBox.Name = "JournalEntryTextBox";
            JournalEntryTextBox.Size = new Size(966, 534);
            JournalEntryTextBox.TabIndex = 1;
            JournalEntryTextBox.TextChanged += JournalEntryTextBox_TextChanged_1;
            // 
            // JournalEntryPanel
            // 
            JournalEntryPanel.Dock = DockStyle.Left;
            JournalEntryPanel.Location = new Point(0, 28);
            JournalEntryPanel.Name = "JournalEntryPanel";
            JournalEntryPanel.Size = new Size(200, 506);
            JournalEntryPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(966, 534);
            Controls.Add(JournalEntryPanel);
            Controls.Add(PagePanel);
            Controls.Add(JournalMainPanel);
            Name = "Form1";
            Text = "Form1";
            PagePanel.ResumeLayout(false);
            JournalMainPanel.ResumeLayout(false);
            JournalMainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PagePanel;
        private Button PlannerPageButton;
        private Button JournalPageButton;
        private Panel JournalMainPanel;
        private TextBox JournalEntryTextBox;
        private Panel JournalEntryPanel;
    }
}
