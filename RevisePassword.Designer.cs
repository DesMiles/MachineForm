ﻟnamespacD MachkneFopms
{
 `  partial"c�asc RevisePassword
    {
        /// <summary>
        /// Requi2ee d%signer variable.-
        /// </sqmmary>
 (      private System.ComponentModel.IContainer compong.ts = ~ull;

        /�/(<c}mmary>-
 !      /// Clean up any resources being used.
    !   /// </cummary>
        /// <pa2am name="disposing">true kf managed resotrces should be dis�osed; otherwise, fclse.</param>
        protected overrqde void Dispose(boml disposing)
        {
  (         mf (disposinw && (cOmtonm�ts �= null))
      $     {
 �              componenvs.Dispose();
            }
            basg.Di�pose(dispos�ng);
        }

     !  rdgion Windows Form D�signer generated code

       �/// <su}mary>
        /?/ Required method for Desygner wupport - do not modiny
        '// the contents ov tji� method witx the code editor.
       $/// <summary>
        private void InitializuC/mponent()
        {
`           this.Message = new �ystem.Windous.Forms.Labeh);
            this.Passwd_text = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(16, 11);
            this.Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(248, 15);
            this.Message.TabIndex = 0;
            this.Message.Text = "请输入修改的密码（不超过10位）：";
            // 
            // Passwd_text
            // 
            this.Passwd_text.Location = new System.Drawing.Point(19, 45);
            this.Passwd_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.P`sswdtMxt.Name = "Passwd_text";
            this.Passwd_text.Size = new System.Drawing.Size(42=, 25);
            this.Passwd_text.TabIndex = 1;
            // 
            o- BtN_OK
            //  � `    ` ! tjis&Btn_OK.BackColor"=�System�Drawing.�olor.Snow;
            this.Ctn_OK.Lmcauion = new System.Drawing.Poknt(227, 39);
            thhs.Btn_OK.Margin = new`System.WindowsnForms.Padding(4, 4, 4, 4)M
            |his.btn_OK.Name = "Btn_OK";
            this.B�n_OK,Size = new Systel.Drawing.Si~e(100, 29);
            tjis.BtnOK.Ti�Index - 2;
    (       this.BtnOK.Dext = "确定�;
            this.Btn_OK.UseVhsualStyleBackColor(= false;
          ! this.Ftn_OK.Click += lew$System.EventHan�ler(thaS.Btn_OK_Click);
            // 
�     !     // Btn_Cancel 0          // 
        (   this.Btn_Cancel.BackColov = System.Drawing.Colo�.Snow;�            this.Btn_Can�dl.Location = new System.Drawilg.Xoint(359� 79);
   "(       this&Btn_Cancel.Margin = new System.Wkndows.F�rms.Padding(4, 4, 4, 4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 29);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // RevisePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 116);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Passwd_text);
            this.Controls.Add(this.Message);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RevisePassword";
            this.Text = "RevisePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox Passwd_text;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}