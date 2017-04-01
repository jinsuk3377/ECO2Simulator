using System.IO;
using System.Runtime.Remoting.Messaging;

namespace ADR2013AppCS01
{
  partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axCExpressViewerControl1 = new AxExpressViewerDll.AxCExpressViewerControl();
            this.Load_DWF = new System.Windows.Forms.Button();  // load_dwf 버튼 생성
            this.DWF_Property = new System.Windows.Forms.Button();  // dwf_property 버튼 생성
            this.button_ObjProp = new System.Windows.Forms.Button();    // button_objprop 버튼 생성
            this.Convert_click= new System.Windows.Forms.Button();
            this.Gbxml_Property = new System.Windows.Forms.Button();
            //this.button_hideObj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();         // 대화상자 생성
          
            ((System.ComponentModel.ISupportInitialize)(this.axCExpressViewerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axCExpressViewerControl1
            // 
            this.axCExpressViewerControl1.Enabled = true;
            this.axCExpressViewerControl1.Location = new System.Drawing.Point(12, 11);
            this.axCExpressViewerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axCExpressViewerControl1.Name = "axCExpressViewerControl1";
            this.axCExpressViewerControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCExpressViewerControl1.OcxState")));
            this.axCExpressViewerControl1.Size = new System.Drawing.Size(666, 475);
            this.axCExpressViewerControl1.TabIndex = 0;
            // 
            // Load_DWF
            // 
            this.Load_DWF.Location = new System.Drawing.Point(26, 503);
            this.Load_DWF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Load_DWF.Name = "Load_DWF";
            this.Load_DWF.Size = new System.Drawing.Size(89, 30);
            this.Load_DWF.TabIndex = 1;
            this.Load_DWF.Text = "Load DWF";
            this.Load_DWF.UseVisualStyleBackColor = true;
            this.Load_DWF.Click += new System.EventHandler(this.button1_Click);

           
            
            // 
            // DWF_Property
            // 
            this.DWF_Property.Location = new System.Drawing.Point(126, 503); //568
            this.DWF_Property.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DWF_Property.Name = "DWF_Property";
            this.DWF_Property.Size = new System.Drawing.Size(101, 30);
            this.DWF_Property.TabIndex = 3;
            this.DWF_Property.Text = "DWF_Property";
            this.DWF_Property.UseVisualStyleBackColor = true;
            this.DWF_Property.Click += new System.EventHandler(this.DWF_Property_Click);    // 버튼을 클릭했을 때 이벤트 발생
            // 
            // button_ObjProp
            // 
            this.button_ObjProp.Location = new System.Drawing.Point(236, 503);
            this.button_ObjProp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ObjProp.Name = "button_ObjProp";
            this.button_ObjProp.Size = new System.Drawing.Size(97, 30);
            this.button_ObjProp.TabIndex = 5;
            this.button_ObjProp.Text = "Object Prop.";
            this.button_ObjProp.UseVisualStyleBackColor = true;
            this.button_ObjProp.Click += new System.EventHandler(this.button_ObjProp_Click);    // 버튼을 클릭했을 때 이벤트 발생


            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 509);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 101);
            this.textBox1.TabIndex = 8;


            // Convert now
            //
            this.Convert_click.Location = new System.Drawing.Point(26, 550);
            this.Convert_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Convert_click.Name = "Convert Now";
            this.Convert_click.Size = new System.Drawing.Size(89, 30);
            this.Convert_click.TabIndex = 9;
            this.Convert_click.Text = "Convert Now";
            this.Convert_click.UseVisualStyleBackColor = true;
            this.Convert_click.Click += new System.EventHandler(this.Convert_Click);

            // Gbxml Property
            this.Gbxml_Property.Location = new System.Drawing.Point(126, 550);
            this.Gbxml_Property.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gbxml_Property.Name = "Gbxml_Property";
            this.Gbxml_Property.Size = new System.Drawing.Size(120, 30);
            this.Gbxml_Property.TabIndex = 10;
            this.Gbxml_Property.Text = "Gbxml_Property";
            this.Gbxml_Property.UseVisualStyleBackColor = true;
            this.Gbxml_Property.Click += new System.EventHandler(this.Gbxml_Property_Click);

            // 
            // comboBox1
            // 
            /*
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 509);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 10;
            */
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 661);
            //this.Controls.Add(this.comboBox1);
            //this.Controls.Add(this.objCountBtn);
            this.Controls.Add(this.textBox1);
            //this.Controls.Add(this.button_hideObj);
            this.Controls.Add(this.button_ObjProp);
            this.Controls.Add(this.DWF_Property);
            this.Controls.Add(this.Load_DWF);
            this.Controls.Add(this.axCExpressViewerControl1);
            this.Controls.Add(this.Convert_click);
            this.Controls.Add(this.Gbxml_Property);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Eco2 Converter";
            this.Text = "Eco2 Converter";
            ((System.ComponentModel.ISupportInitialize)(this.axCExpressViewerControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private AxExpressViewerDll.AxCExpressViewerControl axCExpressViewerControl1;
    private System.Windows.Forms.Button Load_DWF;
    private System.Windows.Forms.Button DWF_Property;
    private System.Windows.Forms.Button button_ObjProp;
    //private System.Windows.Forms.Button button_hideObj;
    public System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button Convert_click;
    private System.Windows.Forms.Button Gbxml_Property;

        //private System.Windows.Forms.Button objCountBtn;
        //private System.Windows.Forms.ComboBox comboBox1;
       // private W2dParser parser;

    }
}

