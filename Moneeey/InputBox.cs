using System.ComponentModel;
using System.Windows.Forms;

namespace Money
{
    /// <summary>
    /// The InputBox class is used to show a prompt in a dialog box using the static method Show().
    /// </summary>
    /// <remarks>
    /// Copyright © 2003 Reflection IT
    /// 
    /// This software is provided 'as-is', without any express or implied warranty.
    /// In no event will the authors be held liable for any damages arising from the
    /// use of this software.
    /// 
    /// Permission is granted to anyone to use this software for any purpose,
    /// including commercial applications, subject to the following restrictions:
    /// 
    /// 1. The origin of this software must not be misrepresented; you must not claim
    /// that you wrote the original software. 
    /// 
    /// 2. No substantial portion of the source code of this library may be redistributed
    /// without the express written permission of the copyright holders, where
    /// "substantial" is defined as enough code to be recognizably from this library. 
    /// 
    /// </remarks>
    public class InputBox : System.Windows.Forms.Form
    {
        protected System.Windows.Forms.Button btnOk;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Label lblPrompt;
        protected System.Windows.Forms.TextBox tbInput;
        private IContainer components;

        private InputBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(288, 72);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(376, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            // 
            // textBoxText
            // 
            this.tbInput.Location = new System.Drawing.Point(16, 32);
            this.tbInput.Name = "textBoxText";
            this.tbInput.Size = new System.Drawing.Size(416, 20);
            this.tbInput.TabIndex = 1;
            // 
            // labelPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(15, 15);
            this.lblPrompt.Name = "labelPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(40, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Prompt";
            // 
            // InputBox
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(464, 104);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.Text = "Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// Displays a prompt in a dialog box, and waits for the user to input text or click a button.
        /// </summary>
        /// <param name="prompt">String expression displayed as the message in the dialog box</param>
        /// <param name="title">String expression displayed in the title bar of the dialog box</param>
        /// <param name="defaultResponse">String expression displayed in the text box as the default response</param>
        /// <returns>An InputBoxResult object with the Text and the OK property set to true when OK was clicked.</returns>
        public static InputBoxResult Show(string prompt, string title, string defaultResponse)
        {
            using (InputBox form = new InputBox())
            {
                form.lblPrompt.Text = prompt;
                form.Text = title;
                form.tbInput.Text = defaultResponse;

                DialogResult result = form.ShowDialog();

                InputBoxResult retval = new InputBoxResult();
                if (result == DialogResult.OK)
                {
                    retval.Text = form.tbInput.Text;
                    retval.OK = true;
                }
                return retval;
            }
        }
    }

    /// <summary>
    /// Class used to store the result of an InputBox.Show message.
    /// </summary>
    public class InputBoxResult
    {
        public bool OK;
        public string Text;
    }
}
