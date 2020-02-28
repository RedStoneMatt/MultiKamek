namespace MultiKamek
{
    partial class MultiKamek
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiKamek));
            this.useBetterKamek = new System.Windows.Forms.CheckBox();
            this.pythonPath = new System.Windows.Forms.TextBox();
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.moveNewerASMtoNewerRes = new System.Windows.Forms.CheckBox();
            this.NewerResPath = new System.Windows.Forms.TextBox();
            this.YAMLName = new System.Windows.Forms.TextBox();
            this.devkitPPCPath = new System.Windows.Forms.TextBox();
            this.useClang = new System.Windows.Forms.CheckBox();
            this.LLVMPath = new System.Windows.Forms.TextBox();
            this.noRels = new System.Windows.Forms.CheckBox();
            this.showCMD = new System.Windows.Forms.CheckBox();
            this.keepTemp = new System.Windows.Forms.CheckBox();
            this.CompileButton = new System.Windows.Forms.Button();
            this.generatedCommand = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Example = new System.Windows.Forms.Button();
            this.commandLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveName = new System.Windows.Forms.TextBox();
            this.loadName = new System.Windows.Forms.TextBox();
            this.logs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // useBetterKamek
            // 
            this.useBetterKamek.AutoSize = true;
            this.useBetterKamek.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.useBetterKamek.Location = new System.Drawing.Point(514, 57);
            this.useBetterKamek.Name = "useBetterKamek";
            this.useBetterKamek.Size = new System.Drawing.Size(15, 14);
            this.useBetterKamek.TabIndex = 0;
            this.useBetterKamek.UseVisualStyleBackColor = true;
            this.useBetterKamek.CheckedChanged += new System.EventHandler(this.useBetterKamek_CheckedChanged);
            // 
            // pythonPath
            // 
            this.pythonPath.ForeColor = System.Drawing.Color.Gray;
            this.pythonPath.Location = new System.Drawing.Point(514, 77);
            this.pythonPath.Name = "pythonPath";
            this.pythonPath.Size = new System.Drawing.Size(243, 20);
            this.pythonPath.TabIndex = 1;
            this.pythonPath.Text = "C:\\Python27\\python.exe";
            this.pythonPath.TextChanged += new System.EventHandler(this.pythonPath_TextChanged);
            this.pythonPath.Enter += new System.EventHandler(this.pythonPath_Enter);
            this.pythonPath.Leave += new System.EventHandler(this.pythonPath_Leave);
            // 
            // SourcePath
            // 
            this.SourcePath.Location = new System.Drawing.Point(514, 103);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.Size = new System.Drawing.Size(243, 20);
            this.SourcePath.TabIndex = 2;
            // 
            // moveNewerASMtoNewerRes
            // 
            this.moveNewerASMtoNewerRes.AutoSize = true;
            this.moveNewerASMtoNewerRes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.moveNewerASMtoNewerRes.Location = new System.Drawing.Point(514, 129);
            this.moveNewerASMtoNewerRes.Name = "moveNewerASMtoNewerRes";
            this.moveNewerASMtoNewerRes.Size = new System.Drawing.Size(15, 14);
            this.moveNewerASMtoNewerRes.TabIndex = 3;
            this.moveNewerASMtoNewerRes.UseVisualStyleBackColor = true;
            this.moveNewerASMtoNewerRes.CheckedChanged += new System.EventHandler(this.moveNewerASMtoNewerRes_CheckedChanged);
            // 
            // NewerResPath
            // 
            this.NewerResPath.Location = new System.Drawing.Point(514, 149);
            this.NewerResPath.Name = "NewerResPath";
            this.NewerResPath.ReadOnly = true;
            this.NewerResPath.Size = new System.Drawing.Size(243, 20);
            this.NewerResPath.TabIndex = 4;
            // 
            // YAMLName
            // 
            this.YAMLName.ForeColor = System.Drawing.Color.Gray;
            this.YAMLName.Location = new System.Drawing.Point(514, 241);
            this.YAMLName.Name = "YAMLName";
            this.YAMLName.Size = new System.Drawing.Size(243, 20);
            this.YAMLName.TabIndex = 5;
            this.YAMLName.Text = "NewerProjectKP.yaml";
            this.YAMLName.TextChanged += new System.EventHandler(this.YAMLName_TextChanged);
            this.YAMLName.Enter += new System.EventHandler(this.YAMLName_Enter);
            this.YAMLName.Leave += new System.EventHandler(this.YAMLName_Leave);
            // 
            // devkitPPCPath
            // 
            this.devkitPPCPath.ForeColor = System.Drawing.Color.Gray;
            this.devkitPPCPath.Location = new System.Drawing.Point(514, 267);
            this.devkitPPCPath.Name = "devkitPPCPath";
            this.devkitPPCPath.Size = new System.Drawing.Size(243, 20);
            this.devkitPPCPath.TabIndex = 6;
            this.devkitPPCPath.Text = "C:/devkitPro/devkitPPC/bin/powerpc-eabi";
            this.devkitPPCPath.TextChanged += new System.EventHandler(this.devkitPPCPath_TextChanged);
            this.devkitPPCPath.Enter += new System.EventHandler(this.devkitPPCPath_Enter);
            this.devkitPPCPath.Leave += new System.EventHandler(this.devkitPPCPath_Leave);
            // 
            // useClang
            // 
            this.useClang.AutoSize = true;
            this.useClang.Checked = true;
            this.useClang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useClang.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.useClang.Location = new System.Drawing.Point(514, 293);
            this.useClang.Name = "useClang";
            this.useClang.Size = new System.Drawing.Size(15, 14);
            this.useClang.TabIndex = 7;
            this.useClang.UseVisualStyleBackColor = true;
            this.useClang.CheckedChanged += new System.EventHandler(this.useClang_CheckedChanged);
            // 
            // LLVMPath
            // 
            this.LLVMPath.ForeColor = System.Drawing.Color.Gray;
            this.LLVMPath.Location = new System.Drawing.Point(514, 313);
            this.LLVMPath.Name = "LLVMPath";
            this.LLVMPath.Size = new System.Drawing.Size(243, 20);
            this.LLVMPath.TabIndex = 8;
            this.LLVMPath.Text = "tools/NewerSMBW-LLVM/bin";
            this.LLVMPath.TextChanged += new System.EventHandler(this.LLVMPath_TextChanged);
            this.LLVMPath.Enter += new System.EventHandler(this.LLVMPath_Enter);
            this.LLVMPath.Leave += new System.EventHandler(this.LLVMPath_Leave);
            // 
            // noRels
            // 
            this.noRels.AutoSize = true;
            this.noRels.Checked = true;
            this.noRels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noRels.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noRels.Location = new System.Drawing.Point(514, 339);
            this.noRels.Name = "noRels";
            this.noRels.Size = new System.Drawing.Size(15, 14);
            this.noRels.TabIndex = 9;
            this.noRels.UseVisualStyleBackColor = true;
            // 
            // showCMD
            // 
            this.showCMD.AutoSize = true;
            this.showCMD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showCMD.Location = new System.Drawing.Point(514, 359);
            this.showCMD.Name = "showCMD";
            this.showCMD.Size = new System.Drawing.Size(15, 14);
            this.showCMD.TabIndex = 10;
            this.showCMD.UseVisualStyleBackColor = true;
            // 
            // keepTemp
            // 
            this.keepTemp.AutoSize = true;
            this.keepTemp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.keepTemp.Location = new System.Drawing.Point(514, 379);
            this.keepTemp.Name = "keepTemp";
            this.keepTemp.Size = new System.Drawing.Size(15, 14);
            this.keepTemp.TabIndex = 11;
            this.keepTemp.UseVisualStyleBackColor = true;
            // 
            // CompileButton
            // 
            this.CompileButton.Location = new System.Drawing.Point(514, 431);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(75, 23);
            this.CompileButton.TabIndex = 12;
            this.CompileButton.Text = "Compile";
            this.CompileButton.UseVisualStyleBackColor = true;
            this.CompileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // generatedCommand
            // 
            this.generatedCommand.Location = new System.Drawing.Point(41, 473);
            this.generatedCommand.Name = "generatedCommand";
            this.generatedCommand.ReadOnly = true;
            this.generatedCommand.Size = new System.Drawing.Size(1000, 166);
            this.generatedCommand.TabIndex = 13;
            this.generatedCommand.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Source Code Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "NewerRes Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Main Settings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kamek Settings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Project YAML File:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "devkitPPC Path:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "LLVM Path:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Use BetterKamek:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "No Rels:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Use Clang:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Show CMD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Keep Temp Files:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(285, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Move and Rename NewerASM to NewerRes:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(440, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Python Path:";
            // 
            // Example
            // 
            this.Example.Location = new System.Drawing.Point(1009, 12);
            this.Example.Name = "Example";
            this.Example.Size = new System.Drawing.Size(75, 23);
            this.Example.TabIndex = 28;
            this.Example.Text = "Example";
            this.Example.UseVisualStyleBackColor = true;
            this.Example.Click += new System.EventHandler(this.Example_Click);
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(496, 457);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(110, 13);
            this.commandLabel.TabIndex = 29;
            this.commandLabel.Text = "Generated Command:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(13, 42);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 31;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(94, 14);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(85, 20);
            this.saveName.TabIndex = 32;
            // 
            // loadName
            // 
            this.loadName.Location = new System.Drawing.Point(94, 44);
            this.loadName.Name = "loadName";
            this.loadName.Size = new System.Drawing.Size(85, 20);
            this.loadName.TabIndex = 33;
            // 
            // logs
            // 
            this.logs.AutoSize = true;
            this.logs.Location = new System.Drawing.Point(13, 662);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(0, 13);
            this.logs.TabIndex = 34;
            // 
            // MultiKamek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 687);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.loadName);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.useBetterKamek);
            this.Controls.Add(this.pythonPath);
            this.Controls.Add(this.SourcePath);
            this.Controls.Add(this.moveNewerASMtoNewerRes);
            this.Controls.Add(this.NewerResPath);
            this.Controls.Add(this.YAMLName);
            this.Controls.Add(this.devkitPPCPath);
            this.Controls.Add(this.useClang);
            this.Controls.Add(this.LLVMPath);
            this.Controls.Add(this.noRels);
            this.Controls.Add(this.showCMD);
            this.Controls.Add(this.keepTemp);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.generatedCommand);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Example);
            this.Controls.Add(this.commandLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MultiKamek";
            this.Text = "MultiKamek v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox useBetterKamek;
        private System.Windows.Forms.TextBox pythonPath;
        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.CheckBox moveNewerASMtoNewerRes;
        private System.Windows.Forms.TextBox NewerResPath;
        private System.Windows.Forms.TextBox YAMLName;
        private System.Windows.Forms.TextBox devkitPPCPath;
        private System.Windows.Forms.CheckBox useClang;
        private System.Windows.Forms.TextBox LLVMPath;
        private System.Windows.Forms.CheckBox noRels;
        private System.Windows.Forms.CheckBox showCMD;
        private System.Windows.Forms.CheckBox keepTemp;
        private System.Windows.Forms.Button CompileButton;
        private System.Windows.Forms.RichTextBox generatedCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Example;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox saveName;
        private System.Windows.Forms.TextBox loadName;
        private System.Windows.Forms.Label logs;
    }
}

