﻿/* Z1829678 - Christopher Adams
 * Z1805732 - Kevin Lewis 
 *                                      
 * 
 * CSCI 473 - Assignment 3: A LINQ to the Past
 * Form Designer for Assignment 3
 * */

namespace Assignment_3
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
            this.TextBox_Output = new System.Windows.Forms.RichTextBox();
            this.ComboBox_Class_ClassType = new System.Windows.Forms.ComboBox();
            this.ComboBox_Server_ClassType = new System.Windows.Forms.ComboBox();
            this.ComboBox_Server_PercentRace = new System.Windows.Forms.ComboBox();
            this.ComboBox_Server_RoleTypes = new System.Windows.Forms.ComboBox();
            this.ComboBox_Role_RoleTypes = new System.Windows.Forms.ComboBox();
            this.ComboBox_GuildType = new System.Windows.Forms.ComboBox();
            this.Button_ClassType = new System.Windows.Forms.Button();
            this.Button_PercentRace = new System.Windows.Forms.Button();
            this.Button_RoleTypes = new System.Windows.Forms.Button();
            this.Button_GuildType = new System.Windows.Forms.Button();
            this.Button_FillRole = new System.Windows.Forms.Button();
            this.Button_MaxLevel = new System.Windows.Forms.Button();
            this.NumUpDown_Min_RoleTypes = new System.Windows.Forms.NumericUpDown();
            this.NumUpDown_Max_RoleTypes = new System.Windows.Forms.NumericUpDown();
            this.RadioButton_Tank_FillRole = new System.Windows.Forms.RadioButton();
            this.RadioButton_Damage_FillRole = new System.Windows.Forms.RadioButton();
            this.RadioButton_Healer_FillRole = new System.Windows.Forms.RadioButton();
            this.Panel_PlayerRole = new System.Windows.Forms.Panel();
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
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Min_RoleTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Max_RoleTypes)).BeginInit();
            this.Panel_PlayerRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Output
            // 
            this.TextBox_Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Output.Location = new System.Drawing.Point(426, 55);
            this.TextBox_Output.Name = "TextBox_Output";
            this.TextBox_Output.ReadOnly = true;
            this.TextBox_Output.Size = new System.Drawing.Size(706, 544);
            this.TextBox_Output.TabIndex = 0;
            this.TextBox_Output.Text = "";
            // 
            // ComboBox_Class_ClassType
            // 
            this.ComboBox_Class_ClassType.FormattingEnabled = true;
            this.ComboBox_Class_ClassType.Location = new System.Drawing.Point(25, 97);
            this.ComboBox_Class_ClassType.Name = "ComboBox_Class_ClassType";
            this.ComboBox_Class_ClassType.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Class_ClassType.TabIndex = 1;
            // 
            // ComboBox_Server_ClassType
            // 
            this.ComboBox_Server_ClassType.FormattingEnabled = true;
            this.ComboBox_Server_ClassType.Location = new System.Drawing.Point(158, 97);
            this.ComboBox_Server_ClassType.Name = "ComboBox_Server_ClassType";
            this.ComboBox_Server_ClassType.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Server_ClassType.TabIndex = 2;
            // 
            // ComboBox_Server_PercentRace
            // 
            this.ComboBox_Server_PercentRace.FormattingEnabled = true;
            this.ComboBox_Server_PercentRace.Location = new System.Drawing.Point(158, 180);
            this.ComboBox_Server_PercentRace.Name = "ComboBox_Server_PercentRace";
            this.ComboBox_Server_PercentRace.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Server_PercentRace.TabIndex = 3;
            // 
            // ComboBox_Server_RoleTypes
            // 
            this.ComboBox_Server_RoleTypes.FormattingEnabled = true;
            this.ComboBox_Server_RoleTypes.Location = new System.Drawing.Point(159, 263);
            this.ComboBox_Server_RoleTypes.Name = "ComboBox_Server_RoleTypes";
            this.ComboBox_Server_RoleTypes.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Server_RoleTypes.TabIndex = 4;
            // 
            // ComboBox_Role_RoleTypes
            // 
            this.ComboBox_Role_RoleTypes.FormattingEnabled = true;
            this.ComboBox_Role_RoleTypes.Location = new System.Drawing.Point(26, 263);
            this.ComboBox_Role_RoleTypes.Name = "ComboBox_Role_RoleTypes";
            this.ComboBox_Role_RoleTypes.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Role_RoleTypes.TabIndex = 5;
            // 
            // ComboBox_GuildType
            // 
            this.ComboBox_GuildType.FormattingEnabled = true;
            this.ComboBox_GuildType.Location = new System.Drawing.Point(26, 384);
            this.ComboBox_GuildType.Name = "ComboBox_GuildType";
            this.ComboBox_GuildType.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_GuildType.TabIndex = 6;
            // 
            // Button_ClassType
            // 
            this.Button_ClassType.Location = new System.Drawing.Point(329, 97);
            this.Button_ClassType.Name = "Button_ClassType";
            this.Button_ClassType.Size = new System.Drawing.Size(91, 23);
            this.Button_ClassType.TabIndex = 7;
            this.Button_ClassType.Text = "Show Results";
            this.Button_ClassType.UseVisualStyleBackColor = true;
            this.Button_ClassType.Click += new System.EventHandler(this.Button_ClassType_Click);
            // 
            // Button_PercentRace
            // 
            this.Button_PercentRace.Location = new System.Drawing.Point(329, 180);
            this.Button_PercentRace.Name = "Button_PercentRace";
            this.Button_PercentRace.Size = new System.Drawing.Size(91, 23);
            this.Button_PercentRace.TabIndex = 8;
            this.Button_PercentRace.Text = "Show Results";
            this.Button_PercentRace.UseVisualStyleBackColor = true;
            this.Button_PercentRace.Click += new System.EventHandler(this.Button_PercentRace_Click);
            // 
            // Button_RoleTypes
            // 
            this.Button_RoleTypes.Location = new System.Drawing.Point(330, 263);
            this.Button_RoleTypes.Name = "Button_RoleTypes";
            this.Button_RoleTypes.Size = new System.Drawing.Size(91, 23);
            this.Button_RoleTypes.TabIndex = 9;
            this.Button_RoleTypes.Text = "Show Results";
            this.Button_RoleTypes.UseVisualStyleBackColor = true;
            this.Button_RoleTypes.Click += new System.EventHandler(this.Button_RoleTypes_Click);
            // 
            // Button_GuildType
            // 
            this.Button_GuildType.Location = new System.Drawing.Point(330, 384);
            this.Button_GuildType.Name = "Button_GuildType";
            this.Button_GuildType.Size = new System.Drawing.Size(91, 23);
            this.Button_GuildType.TabIndex = 10;
            this.Button_GuildType.Text = "Show Results";
            this.Button_GuildType.UseVisualStyleBackColor = true;
            this.Button_GuildType.Click += new System.EventHandler(this.Button_GuildType_Click);
            // 
            // Button_FillRole
            // 
            this.Button_FillRole.Location = new System.Drawing.Point(329, 471);
            this.Button_FillRole.Name = "Button_FillRole";
            this.Button_FillRole.Size = new System.Drawing.Size(91, 23);
            this.Button_FillRole.TabIndex = 11;
            this.Button_FillRole.Text = "Show Results";
            this.Button_FillRole.UseVisualStyleBackColor = true;
            this.Button_FillRole.Click += new System.EventHandler(this.Button_FillRole_Click);
            // 
            // Button_MaxLevel
            // 
            this.Button_MaxLevel.Location = new System.Drawing.Point(329, 567);
            this.Button_MaxLevel.Name = "Button_MaxLevel";
            this.Button_MaxLevel.Size = new System.Drawing.Size(91, 23);
            this.Button_MaxLevel.TabIndex = 12;
            this.Button_MaxLevel.Text = "Show Results";
            this.Button_MaxLevel.UseVisualStyleBackColor = true;
            this.Button_MaxLevel.Click += new System.EventHandler(this.Button_MaxLevel_Click);
            // 
            // NumUpDown_Min_RoleTypes
            // 
            this.NumUpDown_Min_RoleTypes.Location = new System.Drawing.Point(26, 305);
            this.NumUpDown_Min_RoleTypes.Name = "NumUpDown_Min_RoleTypes";
            this.NumUpDown_Min_RoleTypes.Size = new System.Drawing.Size(36, 20);
            this.NumUpDown_Min_RoleTypes.TabIndex = 13;
            this.NumUpDown_Min_RoleTypes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_Min_RoleTypes.ValueChanged += new System.EventHandler(this.Min_Max_Changed);
            // 
            // NumUpDown_Max_RoleTypes
            // 
            this.NumUpDown_Max_RoleTypes.Location = new System.Drawing.Point(111, 305);
            this.NumUpDown_Max_RoleTypes.Name = "NumUpDown_Max_RoleTypes";
            this.NumUpDown_Max_RoleTypes.Size = new System.Drawing.Size(36, 20);
            this.NumUpDown_Max_RoleTypes.TabIndex = 14;
            this.NumUpDown_Max_RoleTypes.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumUpDown_Max_RoleTypes.ValueChanged += new System.EventHandler(this.Min_Max_Changed);
            // 
            // RadioButton_Tank_FillRole
            // 
            this.RadioButton_Tank_FillRole.AutoSize = true;
            this.RadioButton_Tank_FillRole.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RadioButton_Tank_FillRole.Location = new System.Drawing.Point(12, 13);
            this.RadioButton_Tank_FillRole.Name = "RadioButton_Tank_FillRole";
            this.RadioButton_Tank_FillRole.Size = new System.Drawing.Size(50, 17);
            this.RadioButton_Tank_FillRole.TabIndex = 15;
            this.RadioButton_Tank_FillRole.TabStop = true;
            this.RadioButton_Tank_FillRole.Text = "Tank";
            this.RadioButton_Tank_FillRole.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Damage_FillRole
            // 
            this.RadioButton_Damage_FillRole.AutoSize = true;
            this.RadioButton_Damage_FillRole.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RadioButton_Damage_FillRole.Location = new System.Drawing.Point(127, 13);
            this.RadioButton_Damage_FillRole.Name = "RadioButton_Damage_FillRole";
            this.RadioButton_Damage_FillRole.Size = new System.Drawing.Size(65, 17);
            this.RadioButton_Damage_FillRole.TabIndex = 16;
            this.RadioButton_Damage_FillRole.TabStop = true;
            this.RadioButton_Damage_FillRole.Text = "Damage";
            this.RadioButton_Damage_FillRole.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Healer_FillRole
            // 
            this.RadioButton_Healer_FillRole.AutoSize = true;
            this.RadioButton_Healer_FillRole.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RadioButton_Healer_FillRole.Location = new System.Drawing.Point(65, 13);
            this.RadioButton_Healer_FillRole.Name = "RadioButton_Healer_FillRole";
            this.RadioButton_Healer_FillRole.Size = new System.Drawing.Size(56, 17);
            this.RadioButton_Healer_FillRole.TabIndex = 17;
            this.RadioButton_Healer_FillRole.TabStop = true;
            this.RadioButton_Healer_FillRole.Text = "Healer";
            this.RadioButton_Healer_FillRole.UseVisualStyleBackColor = true;
            // 
            // Panel_PlayerRole
            // 
            this.Panel_PlayerRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_PlayerRole.Controls.Add(this.RadioButton_Tank_FillRole);
            this.Panel_PlayerRole.Controls.Add(this.RadioButton_Damage_FillRole);
            this.Panel_PlayerRole.Controls.Add(this.RadioButton_Healer_FillRole);
            this.Panel_PlayerRole.Location = new System.Drawing.Point(25, 460);
            this.Panel_PlayerRole.Name = "Panel_PlayerRole";
            this.Panel_PlayerRole.Size = new System.Drawing.Size(200, 48);
            this.Panel_PlayerRole.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(536, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(155, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(155, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(27, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(156, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Server";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(27, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(113, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(27, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(25, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "All Class Type from a Single Server";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(26, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Percentage of Each Race From a Single Server";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(26, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(380, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "All Roles Types from a Single Server Within a Level Range";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(25, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "All Guilds of a Single Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(25, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(345, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "All Players Who Could Fill a Role but Presently Aren\'t";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(26, 537);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(297, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1144, 611);
            this.Controls.Add(this.label15);
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
            this.Controls.Add(this.Panel_PlayerRole);
            this.Controls.Add(this.NumUpDown_Max_RoleTypes);
            this.Controls.Add(this.NumUpDown_Min_RoleTypes);
            this.Controls.Add(this.Button_MaxLevel);
            this.Controls.Add(this.Button_FillRole);
            this.Controls.Add(this.Button_GuildType);
            this.Controls.Add(this.Button_RoleTypes);
            this.Controls.Add(this.Button_PercentRace);
            this.Controls.Add(this.Button_ClassType);
            this.Controls.Add(this.ComboBox_GuildType);
            this.Controls.Add(this.ComboBox_Role_RoleTypes);
            this.Controls.Add(this.ComboBox_Server_RoleTypes);
            this.Controls.Add(this.ComboBox_Server_PercentRace);
            this.Controls.Add(this.ComboBox_Server_ClassType);
            this.Controls.Add(this.ComboBox_Class_ClassType);
            this.Controls.Add(this.TextBox_Output);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Min_RoleTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Max_RoleTypes)).EndInit();
            this.Panel_PlayerRole.ResumeLayout(false);
            this.Panel_PlayerRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox_Output;
        private System.Windows.Forms.ComboBox ComboBox_Class_ClassType;
        private System.Windows.Forms.ComboBox ComboBox_Server_ClassType;
        private System.Windows.Forms.ComboBox ComboBox_Server_PercentRace;
        private System.Windows.Forms.ComboBox ComboBox_Server_RoleTypes;
        private System.Windows.Forms.ComboBox ComboBox_Role_RoleTypes;
        private System.Windows.Forms.ComboBox ComboBox_GuildType;
        private System.Windows.Forms.Button Button_ClassType;
        private System.Windows.Forms.Button Button_PercentRace;
        private System.Windows.Forms.Button Button_RoleTypes;
        private System.Windows.Forms.Button Button_GuildType;
        private System.Windows.Forms.Button Button_FillRole;
        private System.Windows.Forms.Button Button_MaxLevel;
        private System.Windows.Forms.NumericUpDown NumUpDown_Min_RoleTypes;
        private System.Windows.Forms.NumericUpDown NumUpDown_Max_RoleTypes;
        private System.Windows.Forms.RadioButton RadioButton_Tank_FillRole;
        private System.Windows.Forms.RadioButton RadioButton_Damage_FillRole;
        private System.Windows.Forms.RadioButton RadioButton_Healer_FillRole;
        private System.Windows.Forms.Panel Panel_PlayerRole;
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
        private System.Windows.Forms.Label label15;
    }
}

