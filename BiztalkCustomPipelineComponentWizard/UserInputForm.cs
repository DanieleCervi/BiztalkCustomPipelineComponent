using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiztalkCustomPipelineComponentWizard
{
    public partial class UserInputForm : Form
    {
        private static string pcName;
        private static string pcDescription;
        private static string pcCategory;
        private static bool pcEnabled;
        private static Dictionary<string, string> pcProperties;
        private TextBox pcNameTextBox;
        private Label pcNameLabel;
        private Label pcDescriptionLabel;
        private TextBox pcDescriptionTextBox;
        private DataGridView pcPropertiesDataGridView;
        private System.ComponentModel.IContainer components;
        private Label pcPropertiesLabel;
        private Button confirmButton;
        private Label pcCategoryLabel;
        private DataGridViewTextBoxColumn pcPropertyName;
        private DataGridViewComboBoxColumn pcPropertyType;
        private CheckBox pcEnbledCheckBox;
        private Label enabledLabel;
        private ComboBox pcCategoryComboBox;

        public static string PCName => pcName;
        public static string PCDescription => pcDescription;
        public static string PCCategory => pcCategory;
        public static bool PCEnabled => pcEnabled;
        public static Dictionary<string, string> PCProperties => pcProperties;

        public UserInputForm()
        {
            InitializeComponent();
            pcProperties = new Dictionary<string, string>();
        }
        private void InitializeComponent()
        {
            this.pcNameTextBox = new System.Windows.Forms.TextBox();
            this.pcNameLabel = new System.Windows.Forms.Label();
            this.pcDescriptionLabel = new System.Windows.Forms.Label();
            this.pcDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.pcPropertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.pcPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcPropertyType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pcPropertiesLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.pcCategoryLabel = new System.Windows.Forms.Label();
            this.pcCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.pcEnbledCheckBox = new System.Windows.Forms.CheckBox();
            this.enabledLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcPropertiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pcNameTextBox
            // 
            this.pcNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcNameTextBox.Location = new System.Drawing.Point(312, 12);
            this.pcNameTextBox.Name = "pcNameTextBox";
            this.pcNameTextBox.Size = new System.Drawing.Size(270, 22);
            this.pcNameTextBox.TabIndex = 0;
            // 
            // pcNameLabel
            // 
            this.pcNameLabel.AutoSize = true;
            this.pcNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcNameLabel.Location = new System.Drawing.Point(12, 15);
            this.pcNameLabel.Name = "pcNameLabel";
            this.pcNameLabel.Size = new System.Drawing.Size(164, 16);
            this.pcNameLabel.TabIndex = 10;
            this.pcNameLabel.Text = "Pipeline component name";
            // 
            // pcDescriptionLabel
            // 
            this.pcDescriptionLabel.AutoSize = true;
            this.pcDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcDescriptionLabel.Location = new System.Drawing.Point(12, 43);
            this.pcDescriptionLabel.Name = "pcDescriptionLabel";
            this.pcDescriptionLabel.Size = new System.Drawing.Size(196, 16);
            this.pcDescriptionLabel.TabIndex = 0;
            this.pcDescriptionLabel.Text = "Pipeline component description";
            // 
            // pcDescriptionTextBox
            // 
            this.pcDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcDescriptionTextBox.Location = new System.Drawing.Point(312, 40);
            this.pcDescriptionTextBox.Name = "pcDescriptionTextBox";
            this.pcDescriptionTextBox.Size = new System.Drawing.Size(270, 22);
            this.pcDescriptionTextBox.TabIndex = 1;
            // 
            // pcPropertiesDataGridView
            // 
            this.pcPropertiesDataGridView.AllowUserToOrderColumns = true;
            this.pcPropertiesDataGridView.AllowUserToResizeColumns = false;
            this.pcPropertiesDataGridView.AllowUserToResizeRows = false;
            this.pcPropertiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pcPropertiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pcPropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pcPropertiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pcPropertyName,
            this.pcPropertyType});
            this.pcPropertiesDataGridView.Location = new System.Drawing.Point(12, 150);
            this.pcPropertiesDataGridView.Name = "pcPropertiesDataGridView";
            this.pcPropertiesDataGridView.Size = new System.Drawing.Size(570, 197);
            this.pcPropertiesDataGridView.TabIndex = 4;
            // 
            // pcPropertyName
            // 
            this.pcPropertyName.HeaderText = "Property Name";
            this.pcPropertyName.Name = "pcPropertyName";
            // 
            // pcPropertyType
            // 
            this.pcPropertyType.HeaderText = "Property Type";
            this.pcPropertyType.Items.AddRange(new object[] {
            "int",
            "string",
            "bool"});
            this.pcPropertyType.Name = "pcPropertyType";
            // 
            // pcPropertiesLabel
            // 
            this.pcPropertiesLabel.AutoSize = true;
            this.pcPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcPropertiesLabel.Location = new System.Drawing.Point(12, 131);
            this.pcPropertiesLabel.Name = "pcPropertiesLabel";
            this.pcPropertiesLabel.Size = new System.Drawing.Size(256, 16);
            this.pcPropertiesLabel.TabIndex = 1;
            this.pcPropertiesLabel.Text = "Add each property that the pipeline needs";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(486, 362);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 34);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // pcCategoryLabel
            // 
            this.pcCategoryLabel.AutoSize = true;
            this.pcCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcCategoryLabel.Location = new System.Drawing.Point(12, 71);
            this.pcCategoryLabel.Name = "pcCategoryLabel";
            this.pcCategoryLabel.Size = new System.Drawing.Size(183, 16);
            this.pcCategoryLabel.TabIndex = 8;
            this.pcCategoryLabel.Text = "Pipeline component category";
            // 
            // pcCategoryComboBox
            // 
            this.pcCategoryComboBox.FormattingEnabled = true;
            this.pcCategoryComboBox.Items.AddRange(new object[] {
            "Any",
            "AssemblingSerializer",
            "Decoder",
            "DisassemblingParser",
            "Encoder",
            "Parser",
            "PartyResolver",
            "Receiver",
            "Serializer",
            "Streamer",
            "Transmitter",
            "Validate"});
            this.pcCategoryComboBox.Location = new System.Drawing.Point(312, 70);
            this.pcCategoryComboBox.Name = "pcCategoryComboBox";
            this.pcCategoryComboBox.Size = new System.Drawing.Size(270, 21);
            this.pcCategoryComboBox.TabIndex = 2;
            // 
            // pcEnbledCheckBox
            // 
            this.pcEnbledCheckBox.AutoSize = true;
            this.pcEnbledCheckBox.Location = new System.Drawing.Point(312, 98);
            this.pcEnbledCheckBox.Name = "pcEnbledCheckBox";
            this.pcEnbledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.pcEnbledCheckBox.TabIndex = 3;
            this.pcEnbledCheckBox.UseVisualStyleBackColor = true;
            // 
            // enabledLabel
            // 
            this.enabledLabel.AutoSize = true;
            this.enabledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabledLabel.Location = new System.Drawing.Point(15, 98);
            this.enabledLabel.Name = "enabledLabel";
            this.enabledLabel.Size = new System.Drawing.Size(208, 16);
            this.enabledLabel.TabIndex = 9;
            this.enabledLabel.Text = "Add enable flag to the component";
            // 
            // UserInputForm
            // 
            this.AcceptButton = this.confirmButton;
            this.ClientSize = new System.Drawing.Size(594, 412);
            this.Controls.Add(this.enabledLabel);
            this.Controls.Add(this.pcEnbledCheckBox);
            this.Controls.Add(this.pcCategoryComboBox);
            this.Controls.Add(this.pcCategoryLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.pcPropertiesLabel);
            this.Controls.Add(this.pcPropertiesDataGridView);
            this.Controls.Add(this.pcDescriptionTextBox);
            this.Controls.Add(this.pcDescriptionLabel);
            this.Controls.Add(this.pcNameLabel);
            this.Controls.Add(this.pcNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "UserInputForm";
            this.Text = "Biztalk Custom Pipeline Component Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.pcPropertiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            pcName = pcNameTextBox.Text;
            pcDescription = pcDescriptionTextBox.Text;
            pcCategory = pcCategoryComboBox.SelectedItem.ToString();
            pcEnabled = pcEnbledCheckBox.Checked;
            for (int i = 0; i < pcPropertiesDataGridView.RowCount - 1; i++)
                pcProperties.Add(pcPropertiesDataGridView[0, i].Value.ToString(), pcPropertiesDataGridView[1, i].Value.ToString());

            this.Close();
        }
    }
}
