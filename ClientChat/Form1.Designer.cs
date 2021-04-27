namespace ClientChat
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listBox = new System.Windows.Forms.ListBox();
            this.new_msg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // BConnect
            // 
            this.BConnect.Depth = 0;
            this.BConnect.Location = new System.Drawing.Point(868, 39);
            this.BConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.BConnect.Name = "BConnect";
            this.BConnect.Primary = true;
            this.BConnect.Size = new System.Drawing.Size(175, 28);
            this.BConnect.TabIndex = 0;
            this.BConnect.Text = "Connect";
            this.BConnect.UseVisualStyleBackColor = true;
            this.BConnect.Click += new System.EventHandler(this.BConnect_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.SystemColors.Control;
            this.tbUserName.Depth = 0;
            this.tbUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.tbUserName.Hint = "";
            this.tbUserName.Location = new System.Drawing.Point(13, 39);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.SelectedText = "";
            this.tbUserName.SelectionLength = 0;
            this.tbUserName.SelectionStart = 0;
            this.tbUserName.Size = new System.Drawing.Size(395, 28);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "Name";
            this.tbUserName.UseSystemPasswordChar = false;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Items.AddRange(new object[] {
            "Hello there : )"});
            this.listBox.Location = new System.Drawing.Point(16, 94);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1037, 308);
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // new_msg
            // 
            this.new_msg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.new_msg.Depth = 0;
            this.new_msg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_msg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.new_msg.Hint = "";
            this.new_msg.Location = new System.Drawing.Point(16, 410);
            this.new_msg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_msg.Name = "new_msg";
            this.new_msg.PasswordChar = '\0';
            this.new_msg.SelectedText = "";
            this.new_msg.SelectionLength = 0;
            this.new_msg.SelectionStart = 0;
            this.new_msg.Size = new System.Drawing.Size(1039, 100);
            this.new_msg.TabIndex = 3;
            this.new_msg.UseSystemPasswordChar = false;
            this.new_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.new_msg_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 474);
            this.Controls.Add(this.new_msg);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.BConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbUserName;
        private System.Windows.Forms.ListBox listBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField new_msg;
    }
}

