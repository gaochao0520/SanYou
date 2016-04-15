<%@ Control Language="C#" AutoEventWireup="true" %>

<!--top start -->
<div class="top">
    <div class="TopInfo">
        <div class="link"><a onclick="this.style.behavior='url(#default#homepage)';this.setHomePage(this.loaction);" href="#">设为首页</a> | <a href="/page/company.aspx">关于我们</a> | <a href="/page/contact.aspx">联系我们</a></div>
    </div>
    <div class="clearfix"></div>
    <div class="TopLogo">
        <div class="logo">
            <a href="/index.aspx">
                <img src="<%=Lib.theme %>images/logo.png"></a>
        </div>
        <div class="tel">
            <p class="telW">24小时客服热线</p>
            <p class="telN"><%=PB.Get("dianhua") %></p>
        </div>
    </div>
</div>
<!--top end-->