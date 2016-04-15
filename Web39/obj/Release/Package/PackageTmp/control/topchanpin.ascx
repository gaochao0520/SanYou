<%@ Control Language="C#" AutoEventWireup="true" %>

<div class="Sbox">
    <div class="topic">热门产品   Hot</div>
    <div class="list">
        <dl>
            <% var prolist = PB.get_article(5, "types='c'", "id desc");
               foreach (var item in prolist)
               {%>
            <dd><a href='/product/info.aspx?id=<%=item.ID %>' target='_blank' title='<%=item.Title %>'><%=item.Title.Subs(16) %> 3</a></dd>
            <%} %>
        </dl>
    </div>
</div>
<div class="HeightTab clearfix"></div>