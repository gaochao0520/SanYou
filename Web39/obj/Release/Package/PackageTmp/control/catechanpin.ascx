<%@ Control Language="C#" AutoEventWireup="true" %>

<div class="Sbox">
    <div class="topic">公司产品   Product</div>
    <div class="ClassNav">
        <div class="NavTree">
            <ul id='suckertree1'>
                <% var t_pcate = LibCache.get_fenleis("c");
                   foreach (var item in t_pcate)
                   {
                %>
                <li><a href='/product/list.aspx?c=<%=item.ID %>'><%=item.Name %></a>
                </li>
                <%  } %>
            </ul>
        </div>
    </div>
</div>
<div class="HeightTab clearfix"></div>