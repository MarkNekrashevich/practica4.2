namespace practica4._2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nameLabel = new Label();
            countryLabel = new Label();
            priceLabel = new Label();
            nameTextBox = new TextBox();
            countryTextBox = new TextBox();
            priceTextBox = new TextBox();
            addButton = new Button();
            fruitsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)fruitsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(11, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(128, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Название фрукта";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(11, 50);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(161, 20);
            countryLabel.TabIndex = 1;
            countryLabel.Text = "Страна выращивания";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(11, 85);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(45, 20);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Цена";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(178, 15);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(178, 27);
            nameTextBox.TabIndex = 3;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(178, 47);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(178, 27);
            countryTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(178, 82);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(178, 27);
            priceTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(178, 115);
            addButton.Name = "addButton";
            addButton.Size = new Size(178, 29);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить фрукт";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // fruitsDataGridView
            // 
            fruitsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fruitsDataGridView.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Название фрукта" },
                new DataGridViewTextBoxColumn { Name = "Country", HeaderText = "Страна выращивания" },
                new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Цена" }
            });
            fruitsDataGridView.Location = new Point(178, 165);
            fruitsDataGridView.Name = "fruitsDataGridView";
            fruitsDataGridView.RowHeadersWidth = 51;
            fruitsDataGridView.Size = new Size(426, 250);
            fruitsDataGridView.TabIndex = 7;
            fruitsDataGridView.CellContentClick += fruitsDataGridView_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(fruitsDataGridView);
            Controls.Add(addButton);
            Controls.Add(priceTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
            Controls.Add(countryLabel);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fruitsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView fruitsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
