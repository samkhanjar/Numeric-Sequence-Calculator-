<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumricSequenceCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Numric Sequence Calculator</title>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="panel panel-default" style="margin: 10px 10px 10px 10px;">
                <div class="panel-heading">
                    <h3 class="panel-title">Instructions</h3>
                </div>
                <div class="panel-body">
                    <br />
                    Please enter a number to generate sequences. Your entry should be a positive whole number.<br />
                    <br />
                    The software will generate the following sequences:
                <ul>
                    <li>All numbers up to and including the number entered
                    </li>
                    <li>All odd numbers up to and including the number entered
                    </li>
                    <li>All even numbers up to and including the number entered
                    </li>
                    <li>All numbers up to and including the number entered, except when,
                        <ul>
                            <li>A number is a multiple of 3 output C, and when,
                            </li>
                            <li>A number is a multiple of 5 output E, and when,
                            </li>
                            <li>A number is a multiple of both 3 and 5 output Z.
                            </li>
                        </ul>
                    </li>
                    <li>All fibonacci number up to and including the number entered.
                    </li>
                </ul>
                </div>
            </div>
            <div class="panel panel-default" style="margin: 10px 10px 10px 10px;">
                <div class="panel-heading">
                    <h3 class="panel-title">User Entry</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                    <asp:RegularExpressionValidator ID="rev" runat="server"
                        ErrorMessage="Please verify your entry. Only accept positive whole number greater than zero"
                        ControlToValidate="txtEnterData"
                        Font-Bold="true"
                        ForeColor="Red"
                        CssClass="form-control"
                        ValidationExpression="^0*[1-9]\d*$">
                    </asp:RegularExpressionValidator>
                                        
                        <div class="col-md-2" style="text-align: right;">
                            <asp:Label ID="lblEnterData" runat="server" CssClass="control-label" Text="Enter a Number:"></asp:Label>
                        </div>
                        <div class="col-md-3">
                            <asp:TextBox ID="txtEnterData" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="btnCalculate" runat="server" Text="Generate" CausesValidation="true" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-default" style="margin: 10px 10px 10px 10px;">
                <div class="panel-heading">
                    <h3 class="panel-title">Results</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <div class="col-md-12">
                            <b><asp:Label ID="lblAllNumbers" runat="server" Text="All Numbers: "></asp:Label></b>
                        </div>
                        <div class="col-md-12">                            
                            <asp:Label ID="lblAllNumberResults" runat="server"></asp:Label>
                        </div>
                        <div class="col-md-12">
                            <b><asp:Label ID="lblOddNumbers" runat="server" Text="All Odd Numbers: "></asp:Label></b>
                        </div>
                        <div class="col-md-12">                            
                            <asp:Label ID="lblOddNumberResults" runat="server"></asp:Label>
                        </div>
                        <div class="col-md-12">
                            <b><asp:Label ID="lblEvenNumbers" runat="server" Text="All Even Numbers: "></asp:Label></b>
                        </div>
                        <div class="col-md-12">                            
                            <asp:Label ID="lblEvenNumberResults" runat="server"></asp:Label>
                        </div>
                        <div class="col-md-12">
                            <b><asp:Label ID="lblAllNumbersMultipleOf" runat="server" Text="All Numbers: "></asp:Label></b>
                        </div>
                        <div class="col-md-12">                            
                            <asp:Label ID="lblAllNumbersMultipleOfResults" runat="server"></asp:Label>
                        </div>
                        <div class="col-md-12">
                            <b><asp:Label ID="lblFibNumbers" runat="server" Text="All Fibonacci Numbers: "></asp:Label></b>
                        </div>
                        <div class="col-md-12">                            
                            <asp:Label ID="lblFibNumberResults" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
         </div>
    </form>
</body>
</html>
