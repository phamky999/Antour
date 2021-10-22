﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchTour.ascx.cs" Inherits="AnTour.cms.display.Tours.SearchTour" %>
<section id="pack" class="packages">
    <div class="container">
        <div class="gallary-header text-center">
            <h2>Tours
            </h2>
            <p>
                Tìm Kiếm Tour  
            </p>
        </div>
        <div class="row p-3">
            <div class="input-group">
                <input type="text" class="form-control" placeholder="Tìm Kiếm Tour" name="pr_name" value="<%=tukhoa %>" id="keysearch" onkeydown="CheckPostSearch(event)">
                <div class="input-group-append">
                    <a class="btn btn-secondary" href="javascript://" onclick="PostSearch()">
                        <i class="fa fa-search"></i>
                    </a>
                </div>
                <script type="text/javascript">
                    function CheckPostSearch(e) {
                        if (e.keyCode === 13) {
                            PostSearch();

                            e.preventDefault();
                        }
                    }

                    function PostSearch() {
                        $("#keysearch").show().focus();
                        if ($("#keysearch").val() !== "")
                            window.location = "/Default.aspx?modul=Tours&modulphu=Search&tukhoa=" + $("#keysearch").val();
                    }
                </script>
            </div>
        </div>
        
        <!--/.gallery-header-->
        <div class="packages-content">
            <div class="row">
                <asp:Literal ID="LtlMsgSearch" runat="server"></asp:Literal>
                <asp:Literal ID="ltlListTours" runat="server"></asp:Literal>

            </div>
            <!--/.row-->
        </div>
        <!--/.packages-content-->
    </div>
    <!--/.container-->

</section>