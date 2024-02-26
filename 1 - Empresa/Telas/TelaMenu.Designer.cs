namespace _1___Empresa.Telas
{
    partial class TelaMenu
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
            components = new System.ComponentModel.Container();
            menu = new Button();
            panel1 = new Panel();
            label1 = new Label();
            bntHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            menuTransicao = new System.Windows.Forms.Timer(components);
            sidebarTransicao = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bntHam).BeginInit();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ActiveCaptionText;
            menu.Dock = DockStyle.Top;
            menu.ForeColor = SystemColors.Control;
            menu.Location = new Point(0, 0);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(247, 53);
            menu.TabIndex = 0;
            menu.Text = "Cadastrar";
            menu.UseVisualStyleBackColor = false;
            menu.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bntHam);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 40);
            panel1.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 47;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // bntHam
            // 
            bntHam.Image = Properties.Resources.Menu;
            bntHam.Location = new Point(-27, -9);
            bntHam.Name = "bntHam";
            bntHam.Size = new Size(125, 62);
            bntHam.SizeMode = PictureBoxSizeMode.CenterImage;
            bntHam.TabIndex = 47;
            bntHam.TabStop = false;
            bntHam.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ActiveCaptionText;
            sidebar.Controls.Add(menuContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 40);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(258, 589);
            sidebar.TabIndex = 48;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(button3);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(248, 165);
            menuContainer.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(menu);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 45);
            panel2.TabIndex = 49;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Dock = DockStyle.Top;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(3, 55);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(247, 53);
            button3.TabIndex = 1;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.Contacts;
            pictureBox2.Location = new Point(258, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(747, 589);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // menuTransicao
            // 
            menuTransicao.Tick += menuTransicao_Tick;
            // 
            // sidebarTransicao
            // 
            sidebarTransicao.Interval = 10;
            sidebarTransicao.Tick += sidebarTransicao_Tick;
            // 
            // TelaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 629);
            Controls.Add(pictureBox2);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaMenu";
            Text = "TelaMenu";
            Load += TelaMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bntHam).EndInit();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button menu;
        private Panel panel1;
        private PictureBox bntHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private FlowLayoutPanel menuContainer;
        private Button button3;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer menuTransicao;
        private System.Windows.Forms.Timer sidebarTransicao;
    }
}