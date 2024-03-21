namespace appTestArrays
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
      txtNumber = new TextBox();
      btnSave = new Button();
      txtName = new TextBox();
      txtAge = new TextBox();
      txtColor = new TextBox();
      btnSaveDog = new Button();
      SuspendLayout();
      // 
      // txtNumber
      // 
      txtNumber.Font = new Font("Segoe UI", 15F);
      txtNumber.Location = new Point(283, 12);
      txtNumber.Name = "txtNumber";
      txtNumber.Size = new Size(189, 34);
      txtNumber.TabIndex = 0;
      // 
      // btnSave
      // 
      btnSave.Font = new Font("Segoe UI", 15F);
      btnSave.Location = new Point(578, 12);
      btnSave.Name = "btnSave";
      btnSave.Size = new Size(164, 47);
      btnSave.TabIndex = 1;
      btnSave.Text = "Save";
      btnSave.UseVisualStyleBackColor = true;
      btnSave.Click += btnSave_Click;
      // 
      // txtName
      // 
      txtName.Font = new Font("Segoe UI", 15F);
      txtName.Location = new Point(204, 202);
      txtName.Name = "txtName";
      txtName.Size = new Size(189, 34);
      txtName.TabIndex = 2;
      // 
      // txtAge
      // 
      txtAge.Font = new Font("Segoe UI", 15F);
      txtAge.Location = new Point(204, 242);
      txtAge.Name = "txtAge";
      txtAge.Size = new Size(189, 34);
      txtAge.TabIndex = 3;
      // 
      // txtColor
      // 
      txtColor.Font = new Font("Segoe UI", 15F);
      txtColor.Location = new Point(204, 282);
      txtColor.Name = "txtColor";
      txtColor.Size = new Size(189, 34);
      txtColor.TabIndex = 4;
      // 
      // btnSaveDog
      // 
      btnSaveDog.Font = new Font("Segoe UI", 15F);
      btnSaveDog.Location = new Point(498, 276);
      btnSaveDog.Name = "btnSaveDog";
      btnSaveDog.Size = new Size(164, 47);
      btnSaveDog.TabIndex = 5;
      btnSaveDog.Text = "Save Dog";
      btnSaveDog.UseVisualStyleBackColor = true;
      btnSaveDog.Click += btnSaveDog_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(btnSaveDog);
      Controls.Add(txtColor);
      Controls.Add(txtAge);
      Controls.Add(txtName);
      Controls.Add(btnSave);
      Controls.Add(txtNumber);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox txtNumber;
    private Button btnSave;
    private TextBox txtName;
    private TextBox txtAge;
    private TextBox txtColor;
    private Button btnSaveDog;
  }
}
