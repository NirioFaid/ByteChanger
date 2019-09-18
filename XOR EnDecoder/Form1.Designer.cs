namespace XOR_EnDecoder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.meatButton = new System.Windows.Forms.Button();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.inputRTB = new System.Windows.Forms.RichTextBox();
            this.outputRTB = new System.Windows.Forms.RichTextBox();
            this.testStringButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.byteConvertButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.byteRepackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meatButton
            // 
            resources.ApplyResources(this.meatButton, "meatButton");
            this.meatButton.Name = "meatButton";
            this.meatButton.UseVisualStyleBackColor = true;
            this.meatButton.Click += new System.EventHandler(this.button_Click);
            // 
            // keyInput
            // 
            resources.ApplyResources(this.keyInput, "keyInput");
            this.keyInput.Name = "keyInput";
            this.keyInput.Tag = "Сюда вводить ключ";
            // 
            // inputRTB
            // 
            resources.ApplyResources(this.inputRTB, "inputRTB");
            this.inputRTB.Name = "inputRTB";
            // 
            // outputRTB
            // 
            resources.ApplyResources(this.outputRTB, "outputRTB");
            this.outputRTB.Name = "outputRTB";
            this.outputRTB.ReadOnly = true;
            // 
            // testStringButton
            // 
            resources.ApplyResources(this.testStringButton, "testStringButton");
            this.testStringButton.Name = "testStringButton";
            this.testStringButton.UseVisualStyleBackColor = true;
            this.testStringButton.Click += new System.EventHandler(this.testStringButton_Click);
            // 
            // copyButton
            // 
            resources.ApplyResources(this.copyButton, "copyButton");
            this.copyButton.Name = "copyButton";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            resources.ApplyResources(this.pasteButton, "pasteButton");
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // exportButton
            // 
            resources.ApplyResources(this.exportButton, "exportButton");
            this.exportButton.Name = "exportButton";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            resources.ApplyResources(this.importButton, "importButton");
            this.importButton.Name = "importButton";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // byteConvertButton
            // 
            resources.ApplyResources(this.byteConvertButton, "byteConvertButton");
            this.byteConvertButton.Name = "byteConvertButton";
            this.byteConvertButton.UseVisualStyleBackColor = true;
            this.byteConvertButton.Click += new System.EventHandler(this.byteConvertButton_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // byteRepackButton
            // 
            resources.ApplyResources(this.byteRepackButton, "byteRepackButton");
            this.byteRepackButton.Name = "byteRepackButton";
            this.byteRepackButton.UseVisualStyleBackColor = true;
            this.byteRepackButton.Click += new System.EventHandler(this.byteRepackButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.byteRepackButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.byteConvertButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.testStringButton);
            this.Controls.Add(this.outputRTB);
            this.Controls.Add(this.inputRTB);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.meatButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button meatButton;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.RichTextBox inputRTB;
        private System.Windows.Forms.RichTextBox outputRTB;
        private System.Windows.Forms.Button testStringButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button byteConvertButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button byteRepackButton;
    }
}

