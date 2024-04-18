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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            textBoxSearch = new TextBox();
            buttonViewAll = new Button();
            buttonSearch = new Button();
            dataGridViewUsers = new DataGridView();
            buttonLogout = new Button();
            labelLoggedUser = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
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
            numericUpDownUserID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
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
            labelSearch.Size = new Size(138, 27);
            labelSearch.TabIndex = 11;
            labelSearch.Text = "Search Role";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(511, 180);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(302, 22);
            textBoxSearch.TabIndex = 12;
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
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Montserrat SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewUsers.Location = new Point(59, 296);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(754, 319);
            dataGridViewUsers.TabIndex = 15;
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Montserrat", 8F);
            buttonLogout.Location = new Point(124, 680);
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
            labelLoggedUser.Size = new Size(209, 20);
            labelLoggedUser.TabIndex = 17;
            labelLoggedUser.Text = "Logged in as Administrator";
            // 
            // VAdministrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.adminBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 733);
            Controls.Add(labelLoggedUser);
            Controls.Add(buttonLogout);
            Controls.Add(dataGridViewUsers);
            Controls.Add(buttonSearch);
            Controls.Add(buttonViewAll);
            Controls.Add(textBoxSearch);
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
            Name = "VAdministrator";
            Text = "AdministratorGUI";
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
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
        private TextBox textBoxSearch;
        private Button buttonViewAll;
        private Button buttonSearch;
        private DataGridView dataGridViewUsers;
        private Button buttonLogout;
        private Label labelLoggedUser;
    }
}