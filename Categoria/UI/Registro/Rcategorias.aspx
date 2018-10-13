<%@ Page Title="Categoria" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Rcategorias.aspx.cs" Inherits="Category.UI.Registro.Rcategorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class=" panel panel-primary">
        <div class="panel-heading text-center">
            <h1><ins>Categoria</ins></h1>
            <br />
        </div>

        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">
                <%--Id dropdown--%>
                <div class=" form-group">
                    <div class="col-md-8 col-sm-4 ">
                        <label for="Id_DropDownList" class="col-md-3 control-label input-sm">ID:</label>
                        <div class="col-md-4 col-sm-4">
                            <asp:DropDownList ID="Id_DropDownList" OnSelectedIndexChanged="Id_DropDownList_SelectedIndexChanged" ValidationGroup="ID"  AutoPostBack="true" AppendDataBoundItems="true" CssClass="form-control input-sm" runat="server"></asp:DropDownList>
                            <asp:CustomValidator ID="CustomValidator1" ValidationGroup="ID" Display="Dynamic" SetFocusOnError="true" CssClass="ErrorMessage" ControlToValidate="Id_DropDownList" runat="server" ErrorMessage="Seleccione una Cuenta"></asp:CustomValidator>
                        </div>
                    </div>
                </div>

                <%--Descripcion--%>
                <div class="form-group">
                    <div class="col-md-8 col-sm-4">
                        <label for="DescripcionBox" class="col-md-3 control-label input-sm">Descripcion:</label>
                        <div class="col-md-4 col-sm-4">
                            <asp:TextBox ID="DescripcionBox" ValidationGroup="Guardar" placeholder="Descripcion" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="Guardar" ID="RequiredFieldValidator2" ControlToValidate="DescripcionBox" CssClass="ErrorMessage" runat="server" ErrorMessage="Ingrese una Descipcion"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <%--Presupuesto--%>
                <div class="form-group">
                    <div class=" col-md-8 col-sm-4">
                        <label for="PresupuestoTextBox" class="col-md-3 control-label input-sm">Descripcion:</label>
                        <div class="col-md-4 col-sm-4">
                            <asp:TextBox ID="PresupuestoTextBox" TextMode="Number" placeholder="Presupuesto" CssClass="form-control"  runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="Guardar" ID="RequiredFieldValidator1" ControlToValidate="PresupuestoTextBox" CssClass="ErrorMessage" runat="server" ErrorMessage="Ingrese una Presupuesto"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <%--Botones--%>
        <div class="panel-footer">
            <div class="text-center">
                <div class="row">
                    <asp:Button OnClick="NuevoButton_Click" Text="Nuevo" class="btn btn-warning btn-md col-md-2 offset-md-4" CausesValidation="false" runat="server" ID="NuevoButton" />
                    <asp:Button  ValidationGroup="Guardar" OnClick="GuadarButton_Click" Text="Guardar" class="btn btn-success btn-md col-md-2 " runat="server" ID="GuadarButton" />
                    <asp:Button  ValidationGroup="ID" OnClick="EliminarButtom_Click" Text="Eliminar" class="btn btn-danger btn-md col-md-2 "  runat="server" ID="EliminarButtom" />

                </div>
            </div>
        </div>

    </div>
</asp:Content>
