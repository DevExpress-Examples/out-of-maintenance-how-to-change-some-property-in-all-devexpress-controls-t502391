Namespace WindowsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
            Me.Form1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.buttonEdit3 = New DevExpress.XtraEditors.ButtonEdit()
            Me.buttonEdit2 = New DevExpress.XtraEditors.ButtonEdit()
            Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit()
            Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            Me.button1 = New System.Windows.Forms.Button()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.controlPatcherRegistrator1 = New WindowsApplication1.ControlPatcherRegistrator(Me.components)
            DirectCast(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.Form1layoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Form1layoutControl1ConvertedLayout.SuspendLayout()
            DirectCast(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' buttonEdit1
            ' 
            Me.buttonEdit1.Location = New System.Drawing.Point(251, 12)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.buttonEdit1.Size = New System.Drawing.Size(451, 20)
            Me.buttonEdit1.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.buttonEdit1.TabIndex = 0
            ' 
            ' Form1layoutControl1ConvertedLayout
            ' 
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.buttonEdit3)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.buttonEdit2)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.dateEdit2)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.textEdit2)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.textEdit1)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.dateEdit1)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.button1)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.buttonEdit1)
            Me.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Form1layoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout"
            Me.Form1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.Form1layoutControl1ConvertedLayout.Size = New System.Drawing.Size(714, 532)
            Me.Form1layoutControl1ConvertedLayout.TabIndex = 8
            ' 
            ' buttonEdit3
            ' 
            Me.buttonEdit3.Location = New System.Drawing.Point(12, 132)
            Me.buttonEdit3.Name = "buttonEdit3"
            Me.buttonEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.buttonEdit3.Size = New System.Drawing.Size(690, 20)
            Me.buttonEdit3.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.buttonEdit3.TabIndex = 7
            ' 
            ' buttonEdit2
            ' 
            Me.buttonEdit2.Location = New System.Drawing.Point(12, 12)
            Me.buttonEdit2.Name = "buttonEdit2"
            Me.buttonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.buttonEdit2.Size = New System.Drawing.Size(152, 20)
            Me.buttonEdit2.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.buttonEdit2.TabIndex = 6
            ' 
            ' dateEdit2
            ' 
            Me.dateEdit2.EditValue = Nothing
            Me.dateEdit2.Location = New System.Drawing.Point(251, 60)
            Me.dateEdit2.Name = "dateEdit2"
            Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit2.Size = New System.Drawing.Size(451, 20)
            Me.dateEdit2.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.dateEdit2.TabIndex = 5
            ' 
            ' textEdit2
            ' 
            Me.textEdit2.Location = New System.Drawing.Point(168, 108)
            Me.textEdit2.Name = "textEdit2"
            Me.textEdit2.Size = New System.Drawing.Size(534, 20)
            Me.textEdit2.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.textEdit2.TabIndex = 4
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(168, 84)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(534, 20)
            Me.textEdit1.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.textEdit1.TabIndex = 3
            ' 
            ' dateEdit1
            ' 
            Me.dateEdit1.EditValue = Nothing
            Me.dateEdit1.Location = New System.Drawing.Point(251, 36)
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Size = New System.Drawing.Size(451, 20)
            Me.dateEdit1.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.dateEdit1.TabIndex = 2
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(168, 12)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(79, 68)
            Me.button1.TabIndex = 1
            Me.button1.Text = "button1"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(714, 532)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.buttonEdit3
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem1.Name = "buttonEdit3item"
            Me.layoutControlItem1.Size = New System.Drawing.Size(694, 392)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.buttonEdit2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "buttonEdit2item"
            Me.layoutControlItem2.Size = New System.Drawing.Size(156, 120)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.dateEdit2
            Me.layoutControlItem3.Location = New System.Drawing.Point(239, 48)
            Me.layoutControlItem3.Name = "dateEdit2item"
            Me.layoutControlItem3.Size = New System.Drawing.Size(455, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.textEdit2
            Me.layoutControlItem4.Location = New System.Drawing.Point(156, 96)
            Me.layoutControlItem4.Name = "textEdit2item"
            Me.layoutControlItem4.Size = New System.Drawing.Size(538, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.textEdit1
            Me.layoutControlItem5.Location = New System.Drawing.Point(156, 72)
            Me.layoutControlItem5.Name = "textEdit1item"
            Me.layoutControlItem5.Size = New System.Drawing.Size(538, 24)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.dateEdit1
            Me.layoutControlItem6.Location = New System.Drawing.Point(239, 24)
            Me.layoutControlItem6.Name = "dateEdit1item"
            Me.layoutControlItem6.Size = New System.Drawing.Size(455, 24)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.button1
            Me.layoutControlItem7.Location = New System.Drawing.Point(156, 0)
            Me.layoutControlItem7.Name = "button1item"
            Me.layoutControlItem7.Size = New System.Drawing.Size(83, 72)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.buttonEdit1
            Me.layoutControlItem8.Location = New System.Drawing.Point(239, 0)
            Me.layoutControlItem8.Name = "buttonEdit1item"
            Me.layoutControlItem8.Size = New System.Drawing.Size(455, 24)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' controlPatcherRegistrator1
            ' 
            Me.controlPatcherRegistrator1.ContainerControl = Me
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(714, 532)
            Me.Controls.Add(Me.Form1layoutControl1ConvertedLayout)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.Form1layoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Form1layoutControl1ConvertedLayout.ResumeLayout(False)
            DirectCast(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
        Private button1 As System.Windows.Forms.Button
        Private dateEdit1 As DevExpress.XtraEditors.DateEdit
        Private textEdit1 As DevExpress.XtraEditors.TextEdit
        Private textEdit2 As DevExpress.XtraEditors.TextEdit
        Private dateEdit2 As DevExpress.XtraEditors.DateEdit
        Private buttonEdit2 As DevExpress.XtraEditors.ButtonEdit
        Private buttonEdit3 As DevExpress.XtraEditors.ButtonEdit
        Private Form1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Private controlPatcherRegistrator1 As ControlPatcherRegistrator
    End Class
End Namespace

