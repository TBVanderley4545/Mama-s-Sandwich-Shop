' Programmer:     Ty Vanderley
' Due Date:       March 23, 2015
' Course:         CIS 3680-101 Spring 2015
' Assignment:     Project 1

Public Class Form1

    ' Declare Constants
    Const decSALES_TAX As Decimal = 0.065D           ' The Sales Tax rate
    Const decSTUDENT_DISCOUNT As Decimal = 0.1D      ' The student discount rate
    Const decSMALL_SANDWICH_PRICE As Decimal = 4.5D  ' The price for a small sandwich
    Const decMEDIUM_SANDWICH_PRICE As Decimal = 5.5D ' The price for a medium sandwich
    Const decLARGE_SANDWICH_PRICE As Decimal = 6.5D  ' The price for a large sandwich

    ' Declare Variables
    Dim decSubtotal As Decimal                    ' The calculated subtotal
    Dim decDiscount As Decimal                    ' The calculated discount amount
    Dim decNegativeDiscount As Decimal            ' The calculated discount amount expressed as a negative value
    Dim decSalesTaxAmount As Decimal              ' The calculated sales tax amount
    Dim decDeliveryCharge As Decimal              ' The calculated delivery amount
    Dim decGrandTotal As Decimal                  ' The calculated final total amount
    Dim intQuantity As Integer                    ' The quantity of sandwiches

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click

        GetSandwichSize() ' Returns initial subtotal based on sandwich size

        GetToppingValue() ' Returns subtotal after adding any toppings

        GetGlutenFreeOption() ' Returns subtotal with gluten-free option if selected

        ' Perform data validation instead of try...catch to ensure that a valid integer is entered for quantity, and that it is above 1
        If IsValidQuantity() Then

            If IsWithinRange() Then
                decSubtotal *= CInt(txtQuantity.Text) ' This calculation multiplies the subtotal by the number of sandwiches ordered
            Else
                MessageBox.Show("Please enter an integer that is greater than or equal to 1")
                Exit Sub
            End If

        Else
            MessageBox.Show("Please enter only integers without special characters.")
            Exit Sub
        End If

        ' Display the subtotal to the user in lblSubtotal with currency format
        lblSubtotal.Text = decSubtotal.ToString("C")

        ' Initialize the discount variable so that it has a default value to use if delivery box is checked and subsequently unchecked
        decDiscount = 0

        FactorInDiscount() ' Procedure calculates and applies student discount

        DisplayNegativeDiscount() ' converts discount amount to a negative value and displays it in lblDiscount

        GetSalesTaxAmount() ' calculates and returns sales tax amount

        ' Display the sales tax to the user in lblTax with currency format
        lblTax.Text = decSalesTaxAmount.ToString("C")

        ' Initialize the delivery charge variable so that it has a default value to use if delivery box is checked and subsequently unchecked
        decDeliveryCharge = 0

        GetDeliveryOption() ' function returns decDeliveryCharge to account for delivery charges

        ' Display delivery charge to the user with currency format
        lblDelivery.Text = decDeliveryCharge.ToString("c")

        GetGrandTotal() ' Calculates grand total

        ' Display the grand total for the user with currency format
        lblTotal.Text = decGrandTotal.ToString("C")

    End Sub

    Private Sub btnCompleteOrder_Click(sender As Object, e As EventArgs) Handles btnCompleteOrder.Click

        ' Perform data validation instead of try...catch to ensure that a valid integer is entered for quantity, and that it is above 1
        If IsValidQuantity() Then

            If IsWithinRange() Then
                intQuantity += CInt(txtQuantity.Text)   ' Increase the quantity of sandwiches sold by the quantity entered in txtQuantity after it is converted to an int
            Else
                MessageBox.Show("Please enter an integer that is greater than or equal to 1")
                Exit Sub
            End If

        Else
            MessageBox.Show("Please enter only integers without special characters.")
            Exit Sub
        End If

        ' Message box to show the order is complete
        MessageBox.Show("Thank you for ordering with us, we will have your order ready shortly.")

        ' Call the ClearForm() procedure to clear the order form
        ClearForm()

    End Sub

    Private Sub btnSandwichesServed_Click(sender As Object, e As EventArgs) Handles btnSandwichesServed.Click

        ' When the Sanwiches Served button is pressed, a message box shows the number of sandwiches sold that day
        MessageBox.Show("Today, " & intQuantity & " sandwiches have been sold.")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form and exit the program
        Me.Close()
    End Sub

    ' This function takes no argument, but returns the decSubtotal value depending on which sandwich size is selected
    Public Function GetSandwichSize() As Decimal
        ' This If... ElseIf statement sets the initial subtotal depending on which size sandwich is selected.
        If radSmallSandwich.Checked Then
            decSubtotal = decSMALL_SANDWICH_PRICE
        ElseIf radMediumSandwich.Checked Then
            decSubtotal = decMEDIUM_SANDWICH_PRICE
        ElseIf radLargeSandwich.Checked Then
            decSubtotal = decLARGE_SANDWICH_PRICE
        End If

        Return decSubtotal
    End Function

    ' This function takes no argument, but returns the value of decSubtotal after adding toppings
    Public Function GetToppingValue() As Decimal
        ' Add 30¢ to subtotal if lettuce is selected
        If chkLettuce.Checked Then
            decSubtotal += 0.3
        End If

        ' Add 30¢ to subtotal if tomato is selected
        If chkTomato.Checked Then
            decSubtotal += 0.3
        End If

        ' Add 30¢ to subtotal if onion is selected
        If chkOnion.Checked Then
            decSubtotal += 0.3
        End If

        ' Add 30¢ to subtotal if pickles is selected
        If chkPickles.Checked Then
            decSubtotal += 0.3
        End If

        ' Add 30¢ to subtotal if cheese is selected
        If chkCheese.Checked Then
            decSubtotal += 0.3
        End If

        Return decSubtotal
    End Function

    ' This function takes no argument, but increases the subtotal by $5 if the gluten-free option is selected and returns decSubtotal
    Public Function GetGlutenFreeOption() As Decimal
        If chkGlutenFree.Checked Then
            decSubtotal += 5.0
        End If

        Return decSubtotal
    End Function

    ' This procedure takes no argument, but it factors in the student discount by calling the CalculateDicount and ApplyDiscount functions if chkStudentDiscount is selected
    Public Sub FactorInDiscount()
        If chkStudentDiscount.Checked Then
            CalculateDiscount() ' Calculate discount by calling function
            ApplyDiscount()     ' Apply discount by calling function
        End If
    End Sub

    ' This procedure takes no argument, but calls the GetNegativeDiscount function and displays its value in lblDiscount after it was converted to a string and formatted for currency
    Public Sub DisplayNegativeDiscount()
        ' Display the student discount to the user as a negative value
        GetNegativeDiscount()
        lblDiscount.Text = decNegativeDiscount.ToString("C")
    End Sub

    ' This function takes no argument, but it returns the Discount amount in decDiscount by multiplying decSubtotal by decSTUDENT_DISCOUNT
    Public Function CalculateDiscount() As Decimal
        decDiscount = decSubtotal * decSTUDENT_DISCOUNT

        Return decDiscount
    End Function

    ' This function takes no argument, but returns the decSubtotal after decDiscount is subtracted from it
    Public Function ApplyDiscount() As Decimal
        decSubtotal -= decDiscount

        Return decSubtotal
    End Function

    ' This function takes no argument, but returns the discount amount as a negative value in decNegativeDiscount by multiplying decDiscount by -1
    Public Function GetNegativeDiscount() As Decimal
        decNegativeDiscount = decDiscount * -1

        Return decNegativeDiscount
    End Function

    ' This function takes no argument, but calculates the Sales Tax for the order by multiplying decSubtotal by decSALES_TAX and returns it in decSalesTaxAmount
    Public Function GetSalesTaxAmount() As Decimal
        decSalesTaxAmount = decSubtotal * decSALES_TAX

        Return decSalesTaxAmount
    End Function

    ' This function takes no argument, but adds $5.00 to post tax total by storing this value in decDeliverCharge and returning it if delivery is selected
    Public Function GetDeliveryOption() As Decimal
        If chkDelivery.Checked Then
            decDeliveryCharge += 5.0
        End If

        Return decDeliveryCharge
    End Function

    ' This function takes no argument, but calculates the grand total for the user by adding the subtotal, sales tax, and delivery charge and returns it in decGrandTotal
    Public Function GetGrandTotal() As Decimal
        decGrandTotal = decSubtotal + decSalesTaxAmount + decDeliveryCharge

        Return decGrandTotal
    End Function

    ' This function takes no argument, but performs data validation to ensure the value entered in txtQuantity is an integer and returns a true or false from blnValidQuantity
    Public Function IsValidQuantity() As Boolean
        Dim blnValidQuantity As Boolean  ' This is creating a boolean variable that can be returned true or false depending on a TryParse result
        Dim intQuantityTest As Integer   ' This is creating a variable that is used to try to convert txtQuantity.text into an integer in TryParse

        ' This TryParse returns true if txtQuantity.text can be converted to an Integer, and false if it can't
        If Integer.TryParse(txtQuantity.Text, intQuantityTest) Then
            blnValidQuantity = True
        Else
            blnValidQuantity = False
        End If

        Return blnValidQuantity
    End Function

    ' This function takes no argument, but performs data validation to ensure the value entered in txtQuantity falls in a range of >= 1
    Public Function IsWithinRange() As Boolean
        Dim blnWithinRange As Boolean  ' This is creating a boolean variable that can be returned true or false depending on if value is in range

        If CInt(txtQuantity.Text) >= 1 Then
            blnWithinRange = True
        Else
            blnWithinRange = False
        End If

        Return blnWithinRange
    End Function

    ' This procedure takes no argmunt, but clears the order form by resetting all default values
    Public Sub ClearForm()
        radSmallSandwich.Checked = True ' Return selection to small sandwich
        radTurkey.Checked = True ' Return the meat to Turkey
        chkLettuce.Checked = False ' Uncheck Lettuce
        chkTomato.Checked = False ' Uncheck Tomato
        chkOnion.Checked = False ' Uncheck Onion
        chkPickles.Checked = False ' Uncheck pickles
        chkCheese.Checked = False ' Uncheck Cheese
        chkGlutenFree.Checked = False ' Uncheck Gluten Free
        chkDelivery.Checked = False ' Uncheck Delivery
        chkStudentDiscount.Checked = False ' Uncheck student discount
        txtQuantity.Text = "1" ' Return Quantity to 1
        lblSubtotal.Text = String.Empty ' Clear the subtotal label
        lblDiscount.Text = String.Empty ' Clear the Discount label
        lblTax.Text = String.Empty ' Clear the Sales Tax label
        lblDelivery.Text = String.Empty ' Clear the Delivery Charge label
        lblTotal.Text = String.Empty ' Clear the grand total label
    End Sub
End Class

