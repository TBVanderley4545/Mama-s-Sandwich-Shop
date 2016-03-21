<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLargeSandwich = New System.Windows.Forms.RadioButton()
        Me.radMediumSandwich = New System.Windows.Forms.RadioButton()
        Me.radSmallSandwich = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radTurkey = New System.Windows.Forms.RadioButton()
        Me.radHam = New System.Windows.Forms.RadioButton()
        Me.radRoastBeef = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkPickles = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkStudentDiscount = New System.Windows.Forms.CheckBox()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.chkGlutenFree = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnSandwichesServed = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnCompleteOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radLargeSandwich)
        Me.GroupBox1.Controls.Add(Me.radMediumSandwich)
        Me.GroupBox1.Controls.Add(Me.radSmallSandwich)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Size"
        '
        'radLargeSandwich
        '
        Me.radLargeSandwich.AutoSize = True
        Me.radLargeSandwich.Location = New System.Drawing.Point(21, 169)
        Me.radLargeSandwich.Name = "radLargeSandwich"
        Me.radLargeSandwich.Size = New System.Drawing.Size(114, 17)
        Me.radLargeSandwich.TabIndex = 2
        Me.radLargeSandwich.Text = "Large (12"") - $6.50"
        Me.radLargeSandwich.UseVisualStyleBackColor = True
        '
        'radMediumSandwich
        '
        Me.radMediumSandwich.AutoSize = True
        Me.radMediumSandwich.Location = New System.Drawing.Point(21, 99)
        Me.radMediumSandwich.Name = "radMediumSandwich"
        Me.radMediumSandwich.Size = New System.Drawing.Size(118, 17)
        Me.radMediumSandwich.TabIndex = 1
        Me.radMediumSandwich.Text = "Medium (9"") - $5.50"
        Me.radMediumSandwich.UseVisualStyleBackColor = True
        '
        'radSmallSandwich
        '
        Me.radSmallSandwich.AutoSize = True
        Me.radSmallSandwich.Checked = True
        Me.radSmallSandwich.Location = New System.Drawing.Point(21, 33)
        Me.radSmallSandwich.Name = "radSmallSandwich"
        Me.radSmallSandwich.Size = New System.Drawing.Size(106, 17)
        Me.radSmallSandwich.TabIndex = 0
        Me.radSmallSandwich.TabStop = True
        Me.radSmallSandwich.Text = "Small (6"") - $4.50"
        Me.radSmallSandwich.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radTurkey)
        Me.GroupBox2.Controls.Add(Me.radHam)
        Me.GroupBox2.Controls.Add(Me.radRoastBeef)
        Me.GroupBox2.Location = New System.Drawing.Point(238, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 225)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick Your Meat"
        '
        'radTurkey
        '
        Me.radTurkey.AutoSize = True
        Me.radTurkey.Checked = True
        Me.radTurkey.Location = New System.Drawing.Point(22, 33)
        Me.radTurkey.Name = "radTurkey"
        Me.radTurkey.Size = New System.Drawing.Size(58, 17)
        Me.radTurkey.TabIndex = 3
        Me.radTurkey.TabStop = True
        Me.radTurkey.Text = "Turkey"
        Me.radTurkey.UseVisualStyleBackColor = True
        '
        'radHam
        '
        Me.radHam.AutoSize = True
        Me.radHam.Location = New System.Drawing.Point(22, 99)
        Me.radHam.Name = "radHam"
        Me.radHam.Size = New System.Drawing.Size(47, 17)
        Me.radHam.TabIndex = 4
        Me.radHam.Text = "Ham"
        Me.radHam.UseVisualStyleBackColor = True
        '
        'radRoastBeef
        '
        Me.radRoastBeef.AutoSize = True
        Me.radRoastBeef.Location = New System.Drawing.Point(22, 169)
        Me.radRoastBeef.Name = "radRoastBeef"
        Me.radRoastBeef.Size = New System.Drawing.Size(78, 17)
        Me.radRoastBeef.TabIndex = 5
        Me.radRoastBeef.Text = "Roast Beef"
        Me.radRoastBeef.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.chkCheese)
        Me.GroupBox3.Controls.Add(Me.chkPickles)
        Me.GroupBox3.Controls.Add(Me.chkOnion)
        Me.GroupBox3.Controls.Add(Me.chkTomato)
        Me.GroupBox3.Controls.Add(Me.chkLettuce)
        Me.GroupBox3.Location = New System.Drawing.Point(476, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 225)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pick Your Toppings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "30¢ each"
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(16, 190)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 4
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkPickles
        '
        Me.chkPickles.AutoSize = True
        Me.chkPickles.Location = New System.Drawing.Point(16, 156)
        Me.chkPickles.Name = "chkPickles"
        Me.chkPickles.Size = New System.Drawing.Size(60, 17)
        Me.chkPickles.TabIndex = 3
        Me.chkPickles.Text = "Pickles"
        Me.chkPickles.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(16, 122)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(54, 17)
        Me.chkOnion.TabIndex = 2
        Me.chkOnion.Text = "Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(16, 89)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 1
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(16, 57)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 0
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.chkStudentDiscount)
        Me.GroupBox4.Controls.Add(Me.chkDelivery)
        Me.GroupBox4.Controls.Add(Me.chkGlutenFree)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 297)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 155)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Additional Options"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "* Doesn't apply to delivery charges"
        '
        'chkStudentDiscount
        '
        Me.chkStudentDiscount.AutoSize = True
        Me.chkStudentDiscount.Location = New System.Drawing.Point(21, 100)
        Me.chkStudentDiscount.Name = "chkStudentDiscount"
        Me.chkStudentDiscount.Size = New System.Drawing.Size(156, 17)
        Me.chkStudentDiscount.TabIndex = 7
        Me.chkStudentDiscount.Text = "Student Discount (10% off*)"
        Me.chkStudentDiscount.UseVisualStyleBackColor = True
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(21, 66)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(122, 17)
        Me.chkDelivery.TabIndex = 6
        Me.chkDelivery.Text = "Delivery (Add $5.00)"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'chkGlutenFree
        '
        Me.chkGlutenFree.AutoSize = True
        Me.chkGlutenFree.Location = New System.Drawing.Point(21, 32)
        Me.chkGlutenFree.Name = "chkGlutenFree"
        Me.chkGlutenFree.Size = New System.Drawing.Size(139, 17)
        Me.chkGlutenFree.TabIndex = 5
        Me.chkGlutenFree.Text = "Gluten-Free (Add $5.00)"
        Me.chkGlutenFree.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTotal)
        Me.GroupBox5.Controls.Add(Me.lblSubtotal)
        Me.GroupBox5.Controls.Add(Me.lblDelivery)
        Me.GroupBox5.Controls.Add(Me.lblDiscount)
        Me.GroupBox5.Controls.Add(Me.lblTax)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(444, 297)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(232, 155)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "The Check"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(106, 124)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(103, 13)
        Me.lblTotal.TabIndex = 10
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(106, 32)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(103, 13)
        Me.lblSubtotal.TabIndex = 6
        '
        'lblDelivery
        '
        Me.lblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDelivery.Location = New System.Drawing.Point(106, 101)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(103, 18)
        Me.lblDelivery.TabIndex = 9
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Location = New System.Drawing.Point(106, 55)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(103, 13)
        Me.lblDiscount.TabIndex = 7
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(106, 78)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(103, 15)
        Me.lblTax.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Grand Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Subtotal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Delivery Charge:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Discount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Sales Tax:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(93, 33)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 11
        Me.txtQuantity.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quantity:"
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(21, 502)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(148, 23)
        Me.btnCalculateTotal.TabIndex = 3
        Me.btnCalculateTotal.Text = "&Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnSandwichesServed
        '
        Me.btnSandwichesServed.Location = New System.Drawing.Point(343, 502)
        Me.btnSandwichesServed.Name = "btnSandwichesServed"
        Me.btnSandwichesServed.Size = New System.Drawing.Size(148, 23)
        Me.btnSandwichesServed.TabIndex = 12
        Me.btnSandwichesServed.Text = "&Sandwiches Served"
        Me.btnSandwichesServed.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.txtQuantity)
        Me.GroupBox6.Location = New System.Drawing.Point(223, 353)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 61)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "How Many Sandwiches Like This"
        '
        'btnCompleteOrder
        '
        Me.btnCompleteOrder.Location = New System.Drawing.Point(183, 502)
        Me.btnCompleteOrder.Name = "btnCompleteOrder"
        Me.btnCompleteOrder.Size = New System.Drawing.Size(148, 23)
        Me.btnCompleteOrder.TabIndex = 13
        Me.btnCompleteOrder.Text = "C&omplete Order"
        Me.btnCompleteOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(505, 502)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(688, 564)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCompleteOrder)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btnSandwichesServed)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Mama's Sandwich Shop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radLargeSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents radMediumSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents radSmallSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radTurkey As System.Windows.Forms.RadioButton
    Friend WithEvents radHam As System.Windows.Forms.RadioButton
    Friend WithEvents radRoastBeef As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkPickles As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnion As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkStudentDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents chkGlutenFree As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents btnSandwichesServed As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCompleteOrder As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
