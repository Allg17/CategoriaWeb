<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="cCategoria.aspx.cs" Inherits="Category.UI.Consulta.cCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="row">
            <div class=" col-md-3 col-sm-5 col-lg-2">
                <asp:DropDownList ID="FiltroComboBox" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Todo"></asp:ListItem>
                    <asp:ListItem Text="Idcategoria"></asp:ListItem>
                    <asp:ListItem Text="Descripcion"></asp:ListItem>
                    <asp:ListItem Text="Presupuesto"></asp:ListItem>
                </asp:DropDownList>

            </div>

            <%--Criterio--%>
            <div class="col-md-3 col-sm-4 offset-sm-1 offset-md-1 col-lg-4 ">
                <asp:TextBox ID="CriterioTextBox" placeholder="Criterio" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidator1" Display="Dynamic" SetFocusOnError="true" CssClass="ErrorMessage" ControlToValidate="CriterioTextBox" runat="server" ErrorMessage="Verifique la cadena ingresada y el filtro"></asp:CustomValidator>
            </div>

            <%--Boton Buscar--%>
            <div class="col-md-2 col-sm-2">
                <asp:Button ID="BuscarButton" OnClick="BuscarButton_Click" runat="server" Text="Buscar" CssClass="form-control btn btn-primary" />
            </div>

            <%--Boton Imprimir--%>
            <div class="col-md-2 col-sm-2">
                <asp:Button ID="ImprimirButton" OnClick="ImprimirButton_Click" runat="server" Text="Imprimir" CssClass="form-control btn btn-primary" />
            </div>

        </div>

    </div>



    <%--Grid--%>
    <div class="row">
        <div class=" offset-md-3 col-md-10 col-sm-12">
            <asp:GridView ID="DatosGridView" AllowPaging="true" PageSize="8" OnPageIndexChanging="DatosGridView_PageIndexChanging" runat="server" Width="100%" class="table table-responsive text-center" AutoGenerateColumns="False"
                CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />

                <Columns>

                    <asp:BoundField DataField="Idcategoria" HeaderText="Idcategoria" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                    <asp:BoundField DataField="Presupuesto" HeaderText="Presupuesto" />

                    <asp:TemplateField>
                        <ItemTemplate>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </div>

    </div>



</asp:Content>
