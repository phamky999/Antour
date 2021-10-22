<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HomeLoad.ascx.cs" Inherits="AnTour.cms.display.TrangChu.HomeLoad" %>
<!--Banner slide-->
<div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
    <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner">
        <div class="carousel-item active">
            <a href="#">
                <img class="d-block w-100" src="../../../assets/imgs/banner_1.jpg" alt="slide1"></a>
                
        </div>
        <div class="carousel-item">
            <a href="#">
                <img class="d-block w-100" src="../../../assets/imgs/banner_2.jpg" alt="slide2"></a>
        </div>
        <div class="carousel-item">
            <a href="#">
                <img class="d-block w-100" src="../../../assets/imgs/banner_3.jpg" alt="slide3"></a>
        </div>
    </div>
    <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
    </a>
    <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
    </a>
</div>
<!--Banner slide end-->

<!--List Tour-->
<section id="pack" class="packages pt-5 pb-5">
    <div class="container">
        <div class="gallary-header text-center">
            <h2>Tours
            </h2>
            <p>
                Top Tour Mới Nhất...  
            </p>
        </div>
        <div class="row p-3">
            <div class="input-group">
                
                <input type="text" class="form-control " placeholder="Tìm Kiếm Tour" name="pr_name" value="<%=tukhoa %>" id="keysearch" onkeydown="CheckPostSearch(event)">
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

                <asp:Literal ID="ltlListTours" runat="server"></asp:Literal>

            </div>
            <!--/.row-->
        </div>
        <!--/.packages-content-->
        <div class="d-flex">
            <a class="btn btn-link ml-auto" href="Default.aspx?modul=Tours&modulphu=List">Xem Tất Cả</a>
        </div>
    </div>
    <!--/.container-->

</section>
<!--List Tour end-->
