
namespace video_streaming
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.OutputDevicesList = new System.Windows.Forms.ListView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Output = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Channels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // OutputDevicesList
            // 
            this.OutputDevicesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Output,
            this.Channels});
            this.OutputDevicesList.HideSelection = false;
            this.OutputDevicesList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.OutputDevicesList.Location = new System.Drawing.Point(12, 12);
            this.OutputDevicesList.MultiSelect = false;
            this.OutputDevicesList.Name = "OutputDevicesList";
            this.OutputDevicesList.Size = new System.Drawing.Size(367, 179);
            this.OutputDevicesList.TabIndex = 0;
            this.OutputDevicesList.UseCompatibleStateImageBehavior = false;
            this.OutputDevicesList.View = System.Windows.Forms.View.Details;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(385, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Output
            // 
            this.Output.Text = "Output";
            this.Output.Width = 165;
            // 
            // Channels
            // 
            this.Channels.Text = "Channels";
            this.Channels.Width = 177;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.OutputDevicesList);
            this.Name = "MainForm";
            this.Text = "VideoSC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView OutputDevicesList;
        private System.Windows.Forms.ColumnHeader Output;
        private System.Windows.Forms.ColumnHeader Channels;
        private System.Windows.Forms.Button RefreshButton;
    }
}

