namespace MVVM_ServiceAuto.View
{
    partial class VAdministrator
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelUserID = new Label();
            labelRole = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            numericUpDownUserID = new NumericUpDown();
            textBoxUsername = new TextBox();
            textBoxRole = new TextBox();
            textBoxPassword = new TextBox();
            labelSearch = new Label();
            textBox1 = new TextBox();
            buttonViewAll = new Button();
            buttonSearch = new Button();
            dataGridView1 = new DataGridView();
            userID = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            buttonLogout = new Button();
            labelLoggedUser = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.BackColor = Color.Transparent;
            labelUserID.Font = new Font("Montserrat", 12.75F, FontStyle.Bold);
            labelUserID.ForeColor = Color.White;
            labelUserID.Location = new Point(59, 118);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(75, 24);
            labelUserID.TabIndex = 0;
            labelUserID.Text = "User ID";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.Transparent;
            labelRole.Font = new Font("Montserrat", 12.75F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(59, 199);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(49, 24);
            labelRole.TabIndex = 1;
            labelRole.Text = "Role";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Montserrat", 12.75F, FontStyle.Bold);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(59, 172);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(96, 24);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Montserrat", 12.75F, FontStyle.Bold);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(59, 145);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(101, 24);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Montserrat", 8F);
            buttonAdd.Location = new Point(59, 236);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Montserrat", 8F);
            buttonDelete.Location = new Point(238, 236);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Montserrat", 8F);
            buttonUpdate.Location = new Point(148, 236);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // numericUpDownUserID
            // 
            numericUpDownUserID.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownUserID.Location = new Point(181, 123);
            numericUpDownUserID.Name = "numericUpDownUserID";
            numericUpDownUserID.Size = new Size(132, 22);
            numericUpDownUserID.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(181, 152);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(132, 22);
            textBoxUsername.TabIndex = 8;
            // 
            // textBoxRole
            // 
            textBoxRole.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRole.Location = new Point(181, 208);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(132, 22);
            textBoxRole.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(181, 180);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(132, 22);
            textBoxPassword.TabIndex = 10;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.Transparent;
            labelSearch.Font = new Font("Montserrat", 15F, FontStyle.Bold);
            labelSearch.ForeColor = Color.White;
            labelSearch.Location = new Point(506, 147);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(281, 27);
            labelSearch.TabIndex = 11;
            labelSearch.Text = "Search Username or Role";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(511, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 22);
            textBox1.TabIndex = 12;
            // 
            // buttonViewAll
            // 
            buttonViewAll.Font = new Font("Montserrat", 8F);
            buttonViewAll.Location = new Point(694, 222);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(119, 23);
            buttonViewAll.TabIndex = 13;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Montserrat", 8F);
            buttonSearch.Location = new Point(511, 222);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(116, 23);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userID, username, password, role });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(59, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(754, 319);
            dataGridView1.TabIndex = 15;
            // 
            // userID
            // 
            userID.HeaderText = "User ID";
            userID.Name = "userID";
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.Name = "username";
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.Name = "password";
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.Name = "role";
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Montserrat", 8F);
            buttonLogout.Location = new Point(59, 680);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 16;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // labelLoggedUser
            // 
            labelLoggedUser.AutoSize = true;
            labelLoggedUser.BackColor = Color.Transparent;
            labelLoggedUser.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            labelLoggedUser.ForeColor = Color.White;
            labelLoggedUser.Location = new Point(57, 654);
            labelLoggedUser.Name = "labelLoggedUser";
            labelLoggedUser.Size = new Size(103, 20);
            labelLoggedUser.TabIndex = 17;
            labelLoggedUser.Text = "Logged in as";
            // 
            // AdministratorGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.adminBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 733);
            Controls.Add(labelLoggedUser);
            Controls.Add(buttonLogout);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearch);
            Controls.Add(buttonViewAll);
            Controls.Add(textBox1);
            Controls.Add(labelSearch);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxUsername);
            Controls.Add(numericUpDownUserID);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(labelUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelRole);
            Controls.Add(labelUserID);
            Name = "AdministratorGUI";
            Text = "AdministratorGUI";
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUserID;
        private Label labelRole;
        private Label labelPassword;
        private Label labelUsername;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonUpdate;
        private NumericUpDown numericUpDownUserID;
        private TextBox textBoxUsername;
        private TextBox textBoxRole;
        private TextBox textBoxPassword;
        private Label labelSearch;
        private TextBox textBox1;
        private Button buttonViewAll;
        private Button buttonSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userID;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role;
        private Button buttonLogout;
        private Label labelLoggedUser;
    }
}