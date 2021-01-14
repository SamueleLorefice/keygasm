
using System;
using System.Windows.Input;

namespace Keygasm
{
    partial class KeygasmService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public void OnKeyPressed(object sender, KeyPressedArgs e)
        {
            e.KeyPressed.ToString();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            Program.listener.UnHookKeyboard();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.ServiceName = "KeygasmService";
        }

        #endregion
    }
}
